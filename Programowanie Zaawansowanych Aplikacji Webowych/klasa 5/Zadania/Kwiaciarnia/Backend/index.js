const mysql = require('mysql2/promise');
const express = require('express');
const cors = require('cors');
const fs = require('fs');
const path = require('path');
const { randomUUID } = require('crypto');

const app = express();
const PORT = Number(process.env.PORT || 3100);
const IMAGE_DIRECTORY = path.join(__dirname, 'grafika');
let pool = null;
let server;
const CUSTOMER_FIELDS = {
  klImie: 30,
  klNazwisko: 30,
  ulica: 30,
  nrLokalu: 10,
  kod: 10,
  miejscowosc: 60,
  telefon: 20,
  poczta: 50,
};
const PAYMENT_METHODS = ['Stripe', 'przelew on line', 'PayPal', 'Karta Kredytowa'];
const MAX_ORDER_POSITIONS = 100;
const MAX_QUANTITY = 99;

app.use(cors());
app.use(express.json());

async function onBoot() {
  console.log('Uruchamianie serwera...');
  pool = mysql.createPool({
    host: 'localhost',
    user: 'root',
    password: '',
    database: 'kwiaciarnia',
    waitForConnections: true,
    connectionLimit: 10,
    queueLimit: 0,
  });

  let connection;
  try {
    connection = await pool.getConnection();
    console.log('Połączono z bazą danych kwiaciarni.');
  } catch (error) {
    await pool.end().catch((closeError) => {
      console.error('Nie udało się zamknąć puli po błędzie startu:', closeError.message);
    });
    pool = null;
    throw error;
  } finally {
    if (connection) connection.release();
  }
}

app.get('/api/flowers', async (req, res) => {
  try {
    const [flowers] = await pool.query(
      'SELECT IDkwiat, nazwa, cena, notatka FROM kwiaty;'
    );
    return res.json(flowers);
  } catch (error) {
    console.error('Nie udało się pobrać kwiatów:', error.message);
    return res.status(500).json({ error: 'Nie udało się pobrać kwiatów.' });
  }
});

app.get(/^\/api\/images\/(.+)$/, (req, res) => {
  const filePath = path.resolve(IMAGE_DIRECTORY, req.params[0]);

  if (!filePath.startsWith(IMAGE_DIRECTORY + path.sep)) {
    return res.status(400).send('Invalid image path');
  }

  return fs.readFile(filePath, (error, data) => {
    if (error) {
      if (error.code !== 'ENOENT') console.error('Nie udało się odczytać zdjęcia:', error.message);
      return res.status(error.code === 'ENOENT' ? 404 : 500).send('Nie udało się odczytać zdjęcia.');
    }

    res.type(path.extname(filePath));
    return res.end(data);
  });
});

app.post('/api/orders', async (req, res) => {
  const { klient, platnosc, pozycje } = req.body || {};

  if (!klient || Object.entries(CUSTOMER_FIELDS).some(([field, limit]) =>
    typeof klient[field] !== 'string' || !klient[field].trim() || klient[field].trim().length > limit)) {
    return res.status(400).json({ error: 'Proszę uzupełnić poprawnie wszystkie dane osobowe.' });
  }
  if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(klient.poczta.trim())) {
    return res.status(400).json({ error: 'Proszę podać poprawny adres e-mail.' });
  }
  if (!PAYMENT_METHODS.includes(platnosc)) {
    return res.status(400).json({ error: 'Proszę wybrać sposób płatności.' });
  }
  if (!Array.isArray(pozycje) || !pozycje.length || pozycje.length > MAX_ORDER_POSITIONS
    || pozycje.some((pozycja) => !pozycja
      || !Number.isSafeInteger(pozycja.IDkwiat) || pozycja.IDkwiat < 1
      || !Number.isSafeInteger(pozycja.ilosc) || pozycja.ilosc < 1
      || pozycja.ilosc > MAX_QUANTITY)) {
    return res.status(400).json({ error: 'Koszyk jest pusty lub zawiera nieprawidłowe ilości.' });
  }
  if (new Set(pozycje.map((pozycja) => pozycja.IDkwiat)).size !== pozycje.length) {
    return res.status(400).json({ error: 'Produkt może wystąpić w koszyku tylko raz.' });
  }

  let connection;
  try {
    connection = await pool.getConnection();
    await connection.beginTransaction();

    const [flowers] = await connection.query(
      'SELECT IDkwiat, cena FROM kwiaty WHERE IDkwiat IN (?)',
      [pozycje.map((pozycja) => pozycja.IDkwiat)]
    );
    if (flowers.length !== pozycje.length) {
      await connection.rollback();
      return res.status(400).json({
        error: 'Jeden z kwiatów nie jest już dostępny. Popraw koszyk.',
      });
    }

    const id = randomUUID();
    const customerData = Object.keys(CUSTOMER_FIELDS).map((field) => klient[field].trim());
    await connection.execute(
      'INSERT INTO klienci (IDklient, klImie, klNazwisko, ulica, nrLokalu, kod, miejscowosc, telefon, poczta) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)',
      [id, ...customerData]
    );

    let totalCents = 0;
    for (const pozycja of pozycje) {
      const flower = flowers.find((item) => Number(item.IDkwiat) === pozycja.IDkwiat);
      const priceCents = Math.round(Number(flower.cena) * 100);
      const valueCents = priceCents * pozycja.ilosc;
      totalCents += valueCents;
      await connection.execute(
        'INSERT INTO zamowienia (IDklient, IDkwiat, zamIlosc, cena, wartosc, platnosc) VALUES (?, ?, ?, ?, ?, ?)',
        [id, pozycja.IDkwiat, pozycja.ilosc, priceCents / 100, valueCents / 100, platnosc]
      );
    }

    await connection.commit();
    return res.status(201).json({ id, suma: totalCents / 100 });
  } catch (error) {
    if (connection) {
      await connection.rollback().catch((rollbackError) => {
        console.error('Nie udało się cofnąć transakcji:', rollbackError.message);
      });
    }
    console.error('Nie udało się zapisać zamówienia:', error.message);
    return res.status(500).json({
      error: 'Nie udało się zapisać zamówienia. Spróbuj ponownie.',
    });
  } finally {
    if (connection) connection.release();
  }
});

async function onShutdown() {
  console.log('Zamykanie serwera...');
  if (server) {
    server.close();
    server = undefined;
  }
  if (pool) {
    await pool.end();
    pool = null;
  }
  console.log('Serwer został poprawnie zamknięty.');
}

if (require.main === module) onBoot().then(() => {
  server = app.listen(PORT, () => {
    console.log(`Serwer działa pod adresem http://localhost:${PORT}`);
  });
  const shutdown = () => onShutdown().catch((error) => {
    console.error('Nie udało się poprawnie zamknąć serwera:', error.message);
    process.exitCode = 1;
  });
  process.once('SIGINT', shutdown);
  process.once('SIGTERM', shutdown);
}).catch((error) => {
  console.error('Nie udało się uruchomić serwera:', error.message);
  process.exitCode = 1;
});

module.exports = { app, onBoot, onShutdown };
