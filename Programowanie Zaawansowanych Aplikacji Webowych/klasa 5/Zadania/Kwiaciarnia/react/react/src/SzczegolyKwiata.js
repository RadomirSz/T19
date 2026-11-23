import { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import LinkNowaKarta from './LinkNowaKarta';

function SzczegolyKwiata() {
  const { id } = useParams();
  const [kwiat, setKwiat] = useState(null);
  const [blad, setBlad] = useState('');
  const [ladowanie, setLadowanie] = useState(true);
  const [ilosc, setIlosc] = useState(1);
  const [komunikat, setKomunikat] = useState('');

  useEffect(() => {
    let aktywna = true;
    setLadowanie(true);
    setBlad('');
    setIlosc(1);
    setKomunikat('');
    fetch('http://localhost:3100/api/flowers')
      .then(async (odpowiedz) => {
        const dane = await odpowiedz.json();
        if (!odpowiedz.ok) throw new Error(dane.error || 'Serwer nie mógł wykonać operacji.');
        return dane;
      })
      .then((kwiaty) => {
        if (aktywna) setKwiat(kwiaty.find((element) => String(element.IDkwiat) === id));
      })
      .catch((error) => {
        if (aktywna) setBlad(error.name === 'AbortError' || error instanceof TypeError
          ? 'Brak połączenia z serwerem. Spróbuj ponownie.' : error.message);
      })
      .finally(() => {
        if (aktywna) setLadowanie(false);
      });
    return () => {
      aktywna = false;
    };
  }, [id]);

  if (ladowanie) return <p>Ładowanie...</p>;
  if (blad) return <p role="alert">{blad}</p>;
  if (!kwiat) return <p>Nie znaleziono kwiata.</p>;

  return (
    <main className="szczegoly-kwiata">
      <h2>Wybrany kwiat:</h2>
      <div className="produkt">
        <img
          className="zdjecie-kwiata"
          src={`http://localhost:3100/api/images/${kwiat.IDkwiat}/kwiat.jpg`}
          alt={kwiat.nazwa}
        />
        <div className="dane-kwiata">

          <p>Nazwa: {kwiat.nazwa}</p>
          <p>Cena: {Number(kwiat.cena).toFixed(2)} zł</p>
        </div>
      </div>
      <form onSubmit={(event) => {
        event.preventDefault();
        const liczba = Number(ilosc);
        if (!Number.isSafeInteger(liczba) || liczba < 1) return;
        let koszyk = [];
        try {
          const dane = JSON.parse(localStorage.getItem('koszyk') || '[]');
          if (Array.isArray(dane)) koszyk = dane;
        } catch {
          koszyk = [];
        }
        const pozycja = koszyk.find((element) => element.IDkwiat === kwiat.IDkwiat);
        if (pozycja) {
          pozycja.ilosc += liczba;
        } else {
          koszyk.push({ IDkwiat: kwiat.IDkwiat, nazwa: kwiat.nazwa, cena: kwiat.cena, ilosc: liczba });
        }
        try {
          localStorage.setItem('koszyk', JSON.stringify(koszyk));
          window.dispatchEvent(new Event('zmiana-koszyka'));
          setKomunikat(`Dodano do koszyka: ${liczba} szt. (${kwiat.nazwa}).`);
        } catch {
          setKomunikat('Nie udało się zapisać koszyka.');
        }
      }}>
        <label className="tylko-czytnik" htmlFor="ilosc">Ilość kwiatów</label>
        <div className="kontrolki-koszyka">
          <button type="submit">dodaj do koszyka</button>
          <button type="button" aria-label="Zwiększ ilość" onClick={() => setIlosc(Math.max(1, Number(ilosc) + 1))}>+</button>
          <input
            id="ilosc"
            type="number"
            min="1"
            step="1"
            required
            value={ilosc}
            onChange={(event) => setIlosc(event.target.value)}
          />
          <button type="button" aria-label="Zmniejsz ilość" onClick={() => setIlosc(Math.max(1, Number(ilosc) - 1))}>-</button>
          <LinkNowaKarta className="przycisk-info" to="/koszyk">przejdź do koszyka</LinkNowaKarta>
        </div>
      </form>
      <p role="status">{komunikat}</p>
      <section className="opis-kwiata">
        <h2>Informacja o książce:</h2>
        <p>{kwiat.notatka || 'Brak dodatkowych informacji o kwiecie.'}</p>
      </section>
    </main>
  );
}

export default SzczegolyKwiata;



