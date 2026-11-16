const mysql = require('mysql2/promise');
const express = require('express');
const cors = require('cors');
const fs = require('fs');
const path = require('path');
const app = express();
const PORT = 3100;

let pool = null;
async function onBoot() {
  console.log('Server is booting...');

  try {
    pool = mysql.createPool({
      host: 'localhost',
      user: 'root',
      password: '',
      database: 'ksiegarnia5egr2',
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

app.use(cors());
app.use(express.json());

app.get('/api/books', async (req, res) => {
  try {
    const [books] = await pool.query(
      'SELECT IDksiazka, tytul, cena FROM ksiazki ORDER BY IDksiazka'
    );
    res.json(books);
  } catch (err) {
    console.error('Error fetching books:', err);
    res.status(500).json({ error: 'Nie udało się pobrać książek' });
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

// Boot server
onBoot().then(() => {
  const server = app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
  });
  process.on('SIGINT', onShutdown); // Ctrl+C
  process.on('SIGTERM', onShutdown); // Termination signal
});