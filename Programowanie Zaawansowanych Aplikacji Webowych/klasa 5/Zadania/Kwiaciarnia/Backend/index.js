const mysql = require('mysql2/promise');
const express = require('express');
const cors = require('cors');
const fs = require('fs');
const path = require('path');
const { randomUUID } = require('crypto');

const app = express();
const PORT = Number(process.env.PORT || 3100);
const IMAGE_DIRECTORY = path.join(__dirname, 'grafika');
const pool = mysql.createPool({
  host: process.env.DB_HOST || 'localhost',
  port: Number(process.env.DB_PORT || 3306),
  user: process.env.DB_USER || 'root',
  password: process.env.DB_PASSWORD || '',
  database: process.env.DB_NAME || 'kwiaciarnia',
});

app.use(cors());
app.use(express.json());

app.get('/api/flowers', async (req, res) => {
  try {
    const [flowers] = await pool.query(
      'SELECT IDkwiat, nazwa, cena, notatka FROM kwiaty;'
    );
    res.json(flowers);
  } catch (error) {
    console.error('Error fetching flowers:', error.message);
    res.status(500).json({ error: 'Nie udało się pobrać kwiatów' });
  }
});

app.get(/^\/api\/images\/(.+)$/, (req, res) => {
  const imagePath = req.params[0];
  const filePath = path.resolve(IMAGE_DIRECTORY, imagePath);
  const relativePath = path.relative(IMAGE_DIRECTORY, filePath);

  if (relativePath.startsWith('..') || path.isAbsolute(relativePath)) {
    res.status(400).send('Invalid image path');
    return;
  }

  fs.readFile(filePath, (error, data) => {
    if (error) {
      console.error(error);
      res.status(404).send('Internal server error');
      return;
    }

    res.type(path.extname(filePath));
    res.end(data);
  });
});

app.post('/api/orders', async (req, res) => {
  const { klient, platnosc, pozycje } = req.body || {};
  const customerFields = ['klImie', 'klNazwisko', 'ulica', 'nrLokalu', 'kod', 'miejscowosc', 'telefon', 'poczta'];
  if (!klient || customerFields.some((field) =>
    typeof klient[field] !== 'string' || !klient[field].trim())) {
    return res.status(400).json({ error: 'Proszę uzupełnić wszystkie dane osobowe.' });
  }
  if (!platnosc) {
    return res.status(400).json({ error: 'Proszę wybrać sposób płatności.' });
  }
  if (!Array.isArray(pozycje) || !pozycje.length || pozycje.some((pozycja) =>
    !pozycja || !Number.isSafeInteger(pozycja.IDkwiat) || pozycja.IDkwiat < 1
      || !Number.isSafeInteger(pozycja.ilosc) || pozycja.ilosc < 1)) {
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
      return res.status(400).json({ error: 'Jeden z kwiatów nie jest już dostępny. Popraw koszyk.' });
    }

    const id = randomUUID();
    const customerData = customerFields.map((field) => klient[field].trim());
    await connection.execute(
      'INSERT INTO klienci (IDklient, klImie, klNazwisko, ulica, nrLokalu, kod, miejscowosc, telefon, poczta) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)',
      [id, ...customerData]
    );

    let totalCents = 0;
    for (const position of pozycje) {
      const flower = flowers.find((item) => Number(item.IDkwiat) === position.IDkwiat);
      const priceCents = Math.round(Number(flower.cena) * 100);
      const valueCents = priceCents * position.ilosc;
      totalCents += valueCents;
      await connection.execute(
        'INSERT INTO zamowienia (IDklient, IDkwiat, zamIlosc, cena, wartosc, platnosc) VALUES (?, ?, ?, ?, ?, ?)',
        [id, position.IDkwiat, position.ilosc, priceCents / 100, valueCents / 100, platnosc]
      );
    }

    await connection.commit();
    return res.status(201).json({ id, suma: totalCents / 100 });
  } catch (error) {
    if (connection) {
      await connection.rollback().catch((rollbackError) => console.error('Rollback failed:', rollbackError.message));
    }
    console.error('Nie udało się zapisać zamówienia:', error.message);
    return res.status(500).json({ error: 'Nie udało się zapisać zamówienia. Spróbuj ponownie.' });
  } finally {
    if (connection) connection.release();
  }
});

app.listen(PORT, () => {
  console.log(`Server is running on http://localhost:${PORT}`);
});
