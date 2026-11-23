const mysql = require('mysql2/promise');
const express = require('express');
const cors = require('cors');
const fs = require('fs');
const path = require('path');
const app = express();
const PORT = Number(process.env.PORT || 3100);
const cookieParser = require("cookie-parser");
const { v4: uuidv4 } = require("uuid");
let pool = null;
const { randomUUID } = require('crypto');


app.use(cors());
app.use(express.json());
app.use(cookieParser());


async function onBoot() {
  console.log('Server is booting...');
  try {
    pool = mysql.createPool({
      host: 'localhost',
      user: 'root',
      password: 'rootpassword',
      database: 'kwiaciarnia',
      waitForConnections: true,
      connectionLimit: 10,
      queueLimit: 0,
    });
    console.log('Connected to the MySQL database!');
  } catch (err) {
    console.error('Error:', err);
    process.exit(1);
  }
}


async function onShutdown() {
  console.log('Server is shutting down...');
  if (pool !== null) { await pool.end(); }
  console.log('Cleanup complete. Exiting...');
  process.exit(0);
}

app.get('/api/flowers', async (req, res) => {
  try {
    const [flowers] = await pool.query(
      'SELECT IDkwiat, nazwa, cena, notatka FROM kwiaty;'
    );
    res.json(flowers);
  } catch (err) {
    console.error('Error fetching flowers:', err);
    res.status(500).json({ error: 'Nie udało się pobrać kwatiów' });
  }
});

app.get(/^\/api\/images\/(.+)$/, async (req, res) => {
  const image_path = req.params[0];
  console.log('PATH: ' + image_path);
  const imagesDirectory = path.join(__dirname, 'grafika');
  const filePath = path.resolve(imagesDirectory, image_path);

  if (!filePath.startsWith(imagesDirectory + path.sep)) {
    res.status(400).send('Invalid image path');
    return;
  }

  fs.readFile(filePath, (err, data) => {
    if (err) {
      res.writeHead(404, { 'Content-Type': 'text/plain' });
      res.end('Internal server error');
      console.error(err);
      return;
    }

    res.type(path.extname(filePath));
    res.end(data);
  });
});


app.post('/api/orders', async (req, res) => {
  const { klient, platnosc, pozycje } = req.body || {};
  const pola = { klImie: 30, klNazwisko: 30, ulica: 30, nrLokalu: 10, kod: 10, miejscowosc: 60, telefon: 20, poczta: 50 };
  if (!klient || Object.entries(pola).some(([pole, limit]) =>
    typeof klient[pole] !== 'string' || !klient[pole].trim() || klient[pole].trim().length > limit)) {
    return res.status(400).json({ error: 'Proszę uzupełnić wszystkie dane osobowe.' });
  }
  if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(klient.poczta.trim())) {
    return res.status(400).json({ error: 'Proszę podać poprawny adres e-mail.' });
  }
  if (!['Stripe', 'przelew on line', 'PayPal', 'Karta Kredytowa'].includes(platnosc)) {
    return res.status(400).json({ error: 'Proszę wybrać sposób płatności.' });
  }
  if (!Array.isArray(pozycje) || !pozycje.length || pozycje.length > 100 || pozycje.some(p =>
    !p || !Number.isSafeInteger(p.IDkwiat) || p.IDkwiat < 1 || !Number.isSafeInteger(p.ilosc) || p.ilosc < 1 || p.ilosc > 1000000)) {
    return res.status(400).json({ error: 'Koszyk jest pusty lub zawiera nieprawidłowe ilości.' });
  }
  if (new Set(pozycje.map(p => p.IDkwiat)).size !== pozycje.length) {
    return res.status(400).json({ error: 'Produkt może wystąpić w koszyku tylko raz.' });
  }
  let db;
  try {
    db = await pool.getConnection();
    await db.beginTransaction();
    const [kwiaty] = await db.query('SELECT IDkwiat, cena FROM kwiaty WHERE IDkwiat IN (?)', [pozycje.map(p => p.IDkwiat)]);
    if (kwiaty.length !== pozycje.length) {
      await db.rollback();
      return res.status(400).json({ error: 'Jeden z kwiatów nie jest już dostępny. Popraw koszyk.' });
    }
    const id = randomUUID();
    const dane = Object.keys(pola).map(pole => klient[pole].trim());
    await db.execute('INSERT INTO klienci (IDklient, klImie, klNazwisko, ulica, nrLokalu, kod, miejscowosc, telefon, poczta) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)', [id, ...dane]);
    let sumaGrosze = 0;
    for (const pozycja of pozycje) {
      const kwiat = kwiaty.find(k => Number(k.IDkwiat) === pozycja.IDkwiat);
      const cenaGrosze = Math.round(Number(kwiat.cena) * 100);
      const wartosc = cenaGrosze * pozycja.ilosc;
      sumaGrosze += wartosc;
      await db.execute('INSERT INTO zamowienia (IDklient, IDkwiat, zamIlosc, cena, wartosc, platnosc) VALUES (?, ?, ?, ?, ?, ?)',
        [id, pozycja.IDkwiat, pozycja.ilosc, cenaGrosze / 100, wartosc / 100, platnosc]);
    }
    await db.commit();
    return res.status(201).json({ id, suma: sumaGrosze / 100 });
  } catch (error) {
    if (db) await db.rollback().catch(() => {});
    console.error('Nie udało się zapisać zamówienia:', error.message);
    return res.status(500).json({ error: 'Nie udało się zapisać zamówienia. Spróbuj ponownie.' });
  } finally {
    if (db) db.release();
  }
});

// Boot server
if (require.main === module) onBoot().then(() => {
  const server = app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
  });
  process.on('SIGINT', onShutdown); // Ctrl+C
  process.on('SIGTERM', onShutdown); // Termination signal
});


module.exports = { app, onBoot, onShutdown };

