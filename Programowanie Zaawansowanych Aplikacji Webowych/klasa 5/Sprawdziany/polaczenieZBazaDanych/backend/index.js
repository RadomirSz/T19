const cors = require('cors');
const express = require('express');
const mysql = require('mysql2/promise');
const path = require('path');

const app = express();
const port = Number(process.env.PORT || 5000);
const pool = mysql.createPool({
  host: process.env.DB_HOST || 'localhost',
  port: Number(process.env.DB_PORT || 3306),
  user: process.env.DB_USER || 'root',
  password: process.env.DB_PASSWORD || '',
  database: process.env.DB_NAME || 'ksiegarnia',
  waitForConnections: true,
  connectionLimit: 10,
  queueLimit: 0,
});

app.use(cors());
app.use(express.json());
app.use('/grafika', express.static(path.join(__dirname, 'grafika')));

app.get('/api/books', async (req, res, next) => {
  try {
    const [books] = await pool.query(`
      SELECT ksiazki.IDksiazka AS id,
        ksiazki.tytul AS title,
        CONCAT(autorzy.imie, ' ', autorzy.nazwisko) AS author,
        CONCAT('/grafika/', ksiazki.IDksiazka, '/okladka.jpg') AS cover
      FROM ksiazki
      JOIN autorzy ON autorzy.IDautor = ksiazki.autor
      ORDER BY ksiazki.IDksiazka
    `);
    res.json(books);
  } catch (error) {
    next(error);
  }
});

app.get('/api/authors', async (req, res, next) => {
  try {
    const [authors] = await pool.query(
      `SELECT IDautor AS id,
        CONCAT(imie, ' ', nazwisko) AS name
      FROM autorzy
      ORDER BY nazwisko, imie`,
    );
    res.json(authors);
  } catch (error) {
    next(error);
  }
});

app.use((error, req, res, next) => {
  console.error('Błąd API:', error);
  if (res.headersSent) {
    return next(error);
  }
  const status = Number.isInteger(error.status) && error.status >= 400 && error.status < 500
    ? error.status
    : 500;
  const message = status === 400 && error.type === 'entity.parse.failed'
    ? 'Nieprawidłowy format JSON.'
    : 'Wystąpił błąd serwera lub połączenia z bazą danych.';
  res.status(status).json({ error: message });
});

async function startServer() {
  await pool.query('SELECT 1');
  app.listen(port, () => {
    console.log(`Serwer działa pod adresem http://localhost:${port}`);
  });
}

async function shutdown() {
  await pool.end();
  process.exit(0);
}

process.on('SIGINT', shutdown);
process.on('SIGTERM', shutdown);

startServer().catch(async (error) => {
  console.error('Nie można uruchomić serwera ani połączyć się z bazą ksiegarnia:', error);
  await pool.end();
  process.exit(1);
});
