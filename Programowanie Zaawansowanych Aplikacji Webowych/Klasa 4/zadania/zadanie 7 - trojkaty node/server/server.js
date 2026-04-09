const express = require('express');
const cors = require('cors');
const aplikacja = express();

const PORT_SERWERA = 3100;

aplikacja.use(cors());
aplikacja.use(express.json());

function naLiczbe(wartosc) {
    const sparsowana = Number(wartosc);
    return Number.isFinite(sparsowana) ? sparsowana : NaN;
}

function zbudujNiepowodzenie(komunikat) {
    return {
        canBuild: false,
        message: komunikat,
        kind: null,
    };
}

function klasyfikujZBokow(bokA, bokB, bokC) {
    if (bokA + bokB <= bokC || bokA + bokC <= bokB || bokB + bokC <= bokA) {
        return zbudujNiepowodzenie('Podane liczby nie moga utworzyc trojkata.');
    }

    const boki = [bokA, bokB, bokC].sort((a, b) => a - b);
    const [krotszy, sredni, najdluzszy] = boki;

    const czyRownoboczny = bokA === bokB && bokB === bokC;
    const czyRownoramienny = bokA === bokB || bokA === bokC || bokB === bokC;
    const czyProstokatny = krotszy * krotszy + sredni * sredni === najdluzszy * najdluzszy;

    let rodzaj = 'dowolny';
    if (czyRownoboczny) {
        rodzaj = 'rownoboczny';
    } else if (czyProstokatny) {
        rodzaj = 'prostokatny';
    } else if (czyRownoramienny) {
        rodzaj = 'rownoramienny';
    }

    return {
        canBuild: true,
        message: `Podane boki moga utworzyc trojkat ${rodzaj}.`,
        kind: rodzaj,
    };
}

function klasyfikujZKatow(katA, katB, katC) {
    const sumaKatow = katA + katB + katC;

    if (sumaKatow !== 180) {
        return zbudujNiepowodzenie('Suma katow musi byc rowna 180 stopni.');
    }

    let glownyRodzaj = 'ostrokatny';
    if (katA === 90 || katB === 90 || katC === 90) {
        glownyRodzaj = 'prostokatny';
    } else if (katA > 90 || katB > 90 || katC > 90) {
        glownyRodzaj = 'rozwartokatny';
    }

    const czyRownoboczny = katA === 60 && katB === 60 && katC === 60;
    const czyRownoramienny = katA === katB || katA === katC || katB === katC;

    let dopisek = '';
    if (czyRownoboczny) {
        dopisek = ', rownoboczny';
    } else if (czyRownoramienny) {
        dopisek = ', rownoramienny';
    }

    const rodzaj = `${glownyRodzaj}${dopisek}`;

    return {
        canBuild: true,
        message: `Podane katy moga utworzyc trojkat: ${rodzaj}.`,
        kind: rodzaj,
    };
}

aplikacja.post('/api/triangle', (req, res) => {
    const {
        dataType: rodzajDanych,
        first: pierwszaWartosc,
        second: drugaWartosc,
        third: trzeciaWartosc,
    } = req.body || {};

    if (!rodzajDanych || (rodzajDanych !== 'boki' && rodzajDanych !== 'katy')) {
        return res.status(400).json({ message: 'Nie wybrano rodzaju danych.' });
    }

    if (
        pierwszaWartosc === '' ||
        drugaWartosc === '' ||
        trzeciaWartosc === '' ||
        pierwszaWartosc == null ||
        drugaWartosc == null ||
        trzeciaWartosc == null
    ) {
        return res.status(400).json({ message: 'Prosze wypelnic wszystkie pola.' });
    }

    const wartoscA = naLiczbe(pierwszaWartosc);
    const wartoscB = naLiczbe(drugaWartosc);
    const wartoscC = naLiczbe(trzeciaWartosc);

    if ([wartoscA, wartoscB, wartoscC].some((wartosc) => Number.isNaN(wartosc))) {
        return res.status(400).json({ message: 'Wartosci musza byc liczbami.' });
    }

    if (wartoscA <= 0 || wartoscB <= 0 || wartoscC <= 0) {
        return res.status(400).json({ message: 'Wartosci musza byc dodatnie.' });
    }

    const wynik = 
        (rodzajDanych === 'boki') ? 
            klasyfikujZBokow(wartoscA, wartoscB, wartoscC)
            : 
            klasyfikujZKatow(wartoscA, wartoscB, wartoscC);
    return res.status(200).json(wynik);
});

aplikacja.listen(PORT_SERWERA, () => {
    console.log(`Serwer dziala na http://localhost:${PORT_SERWERA}`);
});