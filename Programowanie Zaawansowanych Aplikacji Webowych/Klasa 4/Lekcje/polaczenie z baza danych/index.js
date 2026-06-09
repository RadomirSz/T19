const mysql = require('mysql2/promise');
const express = require('express');
const cors = require('cors');
const app = express();

const PORT = 3100;

app.use(cors());
app.use(express.json());

async function main() {
  let connection = null;
  try {
    // Create a connection pool
    connection = await mysql.createConnection({
      host: 'localhost',
      user: 'root',
      password: '',
      database: 'ksiazkiklasa',
    });

    console.log('Connected to the MySQL database!');

    // Execute a query
    const [rows, fields] = await connection.execute('SELECT * FROM autorzy');
    console.log('Query Results:', rows);

    // Close the connection
    await connection.end();
    console.log('Connection closed.');
  } catch (err) {
    console.error('Error:', err);
    if (connection !== null) { await connection.end(); }
  }
}


app.get('/api/data', async (req, res) => {
  //const receivedData = req.body;
  let odp = await bazaD();
  console.log('ODP: ', odp);
  res.status(200).json(
    { wynik: odp }
  );
});

app.listen(PORT, () => {
  console.log(`Server is running on http://localhost:${PORT}`);
});

async function bazaD() {

  let pool = null;
  try {
    pool = mysql.createPool({
      host: 'localhost',
      user: 'root',
      password: '',
      database: 'ksiazkiklasa',
      waitForConnections: true,
      connectionLimit: 10,
      queueLimit: 0,
    });

    console.log('Connected to the MySQL database!');

    const [rows] = await pool.execute('SELECT IDautor, nazwisko, imie FROM autorzy');
    console.log('Query Results:', rows)
    // Close the connection
    //await pool.end();
    //console.log('Connection closed.');
    return rows;

  } catch (err) {
    console.error('Error:', err);
    if (pool !== null) { await pool.end(); }
    return 0;
  }
}