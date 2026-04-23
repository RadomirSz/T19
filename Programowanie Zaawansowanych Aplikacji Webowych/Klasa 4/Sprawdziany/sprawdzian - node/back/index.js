const express = require('express');
const cors = require('cors');
const app = express();

app.use(cors());
app.use(express.json());

const PORT = 3100;

app.post('/api/calculate', function (req, res) {
  const { shape, calculation, dimensions } = req.body;

  if (!shape || !calculation || !dimensions) {
    return res.status(400).json({
      error: 'Brak wystarczających danych!'
    });
  }

  let result = null;

  if (shape === 'stozek') {
    const r = toPositiveNumber(dimensions.r);
    const h = toPositiveNumber(dimensions.h);

    if (!r || !h) {
      return res.status(400).json({
        error: 'Dla stożka podaj dodatnie r i h.'
      });
    }

    if (calculation === 'volume') {
      result = obliczObjetoscStozka(r, h);
    }

    if (calculation === 'surfaceArea') {
      result = obliczPoleStozka(r, h);
    }
  }

  if (shape === 'ostroslup') {
    const a = toPositiveNumber(dimensions.a);
    const h = toPositiveNumber(dimensions.h);

    if (!a || !h) {
      return res.status(400).json({
        error: 'Dla ostrosłupa podaj dodatnie a i h.'
      });
    }

    if (calculation === 'volume') {
      result = obliczObjetoscOstroslupa(a, h);
    }

    if (calculation === 'surfaceArea') {
      result = obliczPoleOstroslupa(a, h);
    }
  }

  if (result === null) {
    return res.status(400).json({
      error: 'Niepoprawna bryła lub rodzaj obliczenia.'
    });
  }

  return res.json({ result });
});

app.listen(PORT, function () {
  console.log(`App listening on port ${PORT}!`);
});

function toPositiveNumber(value) {
  const parsed = Number(value);
  if (!Number.isFinite(parsed) || parsed <= 0) {
    return null;
  }

  return parsed;
}

function obliczObjetoscStozka(r, h) {
  return (Math.PI * r * r * h) / 3;
}

function obliczPoleStozka(r, h) {
  return Math.PI * r * (r + h);
}

function obliczObjetoscOstroslupa(a, h) {
  return (a * a * h) / 3;
}

function obliczPoleOstroslupa(a, h) {
  return a * a + 2 * a * h;
}