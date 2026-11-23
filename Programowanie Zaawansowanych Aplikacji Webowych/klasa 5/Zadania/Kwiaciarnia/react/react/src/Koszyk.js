import { useState } from 'react';
import useKoszyk from './useKoszyk';
import PozycjaKoszyka from './PozycjaKoszyka';
import FormularzZamowienia from './FormularzZamowienia';
import LinkNowaKarta from './LinkNowaKarta';

function Koszyk() {
  const { koszyk, zapisz } = useKoszyk();
  const [blad, setBlad] = useState('');
  const [wysylanie, setWysylanie] = useState(false);
  const [potwierdzenie, setPotwierdzenie] = useState(null);
  const zmienKoszyk = (zmiana) => {
    let aktualnyKoszyk = [];
    try {
      const dane = JSON.parse(localStorage.getItem('koszyk') || '[]');
      if (Array.isArray(dane)) aktualnyKoszyk = dane;
    } catch {
      aktualnyKoszyk = [];
    }
    try { zapisz(zmiana(aktualnyKoszyk)); setBlad(''); }
    catch { setBlad('Nie udało się zapisać koszyka.'); }
  };
  
  const wyslij = async (klient, platnosc) => {
    let pozycje = [];
    try {
      const dane = JSON.parse(localStorage.getItem('koszyk') || '[]');
      if (Array.isArray(dane)) pozycje = dane;
    } catch {
      pozycje = [];
    }
    if (!pozycje.length) { setBlad('Koszyk jest pusty.'); return; }
    const kontroler = new AbortController();
    const limit = setTimeout(() => kontroler.abort(), 10000);
    setWysylanie(true);
    setBlad('');
    try {
      const odpowiedz = await fetch('http://localhost:3100/api/orders', {
        signal: kontroler.signal,
        method: 'POST', headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ klient, platnosc, pozycje: pozycje.map(({ IDkwiat, ilosc }) => ({ IDkwiat, ilosc })) }),
      });
      const wynik = await odpowiedz.json();
      if (!odpowiedz.ok) throw new Error(wynik.error || 'Serwer nie mógł wykonać operacji.');
      clearTimeout(limit);
      let aktualnyKoszyk = [];
      try {
        const dane = JSON.parse(localStorage.getItem('koszyk') || '[]');
        if (Array.isArray(dane)) aktualnyKoszyk = dane;
      } catch {
        aktualnyKoszyk = [];
      }
      const pozostale = aktualnyKoszyk.map((kwiat) => {
        const wyslany = pozycje.find((p) => p.IDkwiat === kwiat.IDkwiat);
        return { ...kwiat, ilosc: kwiat.ilosc - (wyslany?.ilosc || 0) };
      }).filter((kwiat) => kwiat.ilosc > 0);
      setPotwierdzenie({ ...wynik, email: klient.poczta });
      try { zapisz(pozostale); }
      catch { setBlad('Zamówienie zostało przyjęte, ale nie udało się wyczyścić koszyka.'); }
    } catch (error) {
      setBlad(error.name === 'AbortError' || error instanceof TypeError
        ? 'Brak połączenia z serwerem. Spróbuj ponownie.' : error.message);
    }
    finally { clearTimeout(limit); setWysylanie(false); }
  };

  if (potwierdzenie) return (
    <main className="potwierdzenie">
      <p>Zamówienie zostało przyjęte do realizacji</p>
      <p>proszę sprawdzić wiadomość na skrzynce pocztowej {potwierdzenie.email}.</p>
      {blad && <p role="alert">{blad}</p>}

    </main>
  );

  return (
    <main className="koszyk">
      
      {blad && <p role="alert">{blad}</p>}
      {koszyk.length === 0 ? (
        <div className="pusty-koszyk"><h2>Zawartość koszyka:</h2><p>Koszyk jest pusty.</p><LinkNowaKarta className="przycisk-info" to="/">Powrót do zakupów</LinkNowaKarta></div>
      ) : (
        <div className="uklad-koszyka">
          <section aria-label="Produkty w koszyku">
            <h2>Zawartość koszyka:</h2>
            <ol className="pozycje-koszyka">
              {koszyk.map((kwiat, index) => (
                <PozycjaKoszyka key={kwiat.IDkwiat} kwiat={kwiat} numer={index + 1} zablokowana={wysylanie}
                  zmienIlosc={(id, ilosc) => zmienKoszyk((aktualnyKoszyk) => aktualnyKoszyk.map((p) => p.IDkwiat === id ? { ...p, ilosc } : p))}
                  usun={(id) => zmienKoszyk((aktualnyKoszyk) => aktualnyKoszyk.filter((p) => p.IDkwiat !== id))}
                />
              ))}
            </ol>
            <p className="suma">Do zapłaty: {(koszyk.reduce((suma, kwiat) => suma + Math.round(Number(kwiat.cena) * 100) * kwiat.ilosc, 0) / 100).toFixed(2)} zł</p>
          </section>
          <FormularzZamowienia wyslij={wyslij} wysylanie={wysylanie} />
        </div>
      )}
    </main>
  );
}

export default Koszyk;


