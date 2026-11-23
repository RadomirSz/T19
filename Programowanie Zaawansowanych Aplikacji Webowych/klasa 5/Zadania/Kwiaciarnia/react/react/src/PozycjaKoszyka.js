import { useEffect, useState } from 'react';
import LinkNowaKarta from './LinkNowaKarta';

function PozycjaKoszyka({ kwiat, numer, zmienIlosc, usun, zablokowana }) {
  const [ilosc, setIlosc] = useState(kwiat.ilosc);
  useEffect(() => setIlosc(kwiat.ilosc), [kwiat.ilosc]);
  return (
    <li className="pozycja-koszyka">
      <div><LinkNowaKarta to={`/kwiat/${kwiat.IDkwiat}`}>{kwiat.nazwa}</LinkNowaKarta> cena: {Number(kwiat.cena).toFixed(2)} zł</div>
      <div>
        <label htmlFor={`ilosc-${kwiat.IDkwiat}`}>zamówiona ilość:</label>
        <input
          id={`ilosc-${kwiat.IDkwiat}`} type="number" min="1" step="1" value={ilosc}
          aria-label={`Zamówiona ilość — ${kwiat.nazwa} (pozycja ${numer})`}
          disabled={zablokowana}
          onChange={(event) => {
            const wartosc = event.target.value;
            setIlosc(wartosc);
            const liczba = Number(wartosc);
            if (liczba > 0) zmienIlosc(kwiat.IDkwiat, liczba);
          }}
          onBlur={() => setIlosc(kwiat.ilosc)}
        />
      </div>
      <button type="button" aria-label={`Usuń ${kwiat.nazwa}`} disabled={zablokowana} onClick={() => usun(kwiat.IDkwiat)}>Usuń</button>
    </li>
  );
}

export default PozycjaKoszyka;
