import { useEffect, useState } from 'react';
import KartaKwiata from './KartaKwiata';

function ListaKwiatow() {
  const [kwiaty, setKwiaty] = useState([]);
  const [blad, setBlad] = useState('');
  const [ladowanie, setLadowanie] = useState(true);
  const [proba, setProba] = useState(0);
  useEffect(() => {
    let aktywna = true;
    setLadowanie(true);
    setBlad('');
    fetch('http://localhost:3100/api/flowers')
      .then(async (odpowiedz) => {
        const dane = await odpowiedz.json();
        if (!odpowiedz.ok) throw new Error(dane.error || 'Serwer nie mógł wykonać operacji.');
        return dane;
      })
      .then((data) => { if (aktywna) setKwiaty(data); })
      .catch((error) => {
        if (aktywna) setBlad(error instanceof TypeError
          ? 'Brak połączenia z serwerem. Spróbuj ponownie.' : error.message);
      })
      .finally(() => {
        if (aktywna) setLadowanie(false);
      });
    return () => {
      aktywna = false;
    };
  }, [proba]);
  return (
    <main>
      <h2>Nasza oferta:</h2>
      {ladowanie && <p role="status">Ładowanie...</p>}
      {blad && <div><p role="alert">{blad}</p><button onClick={() => setProba(proba + 1)}>Spróbuj ponownie</button></div>}
      {!ladowanie && !blad && kwiaty.length === 0 && <p>Brak kwiatów w ofercie.</p>}
      <div className="lista-kwiatow">{kwiaty.map((kwiat) => <KartaKwiata key={kwiat.IDkwiat} kwiat={kwiat} />)}</div>
    </main>
  );
}

export default ListaKwiatow;
