import { useState } from 'react';
import './App.css';
import { TRANSPORT, ZDJECIA, DOMYSLNE_ZDJECIE, CENA_SNIADANIE, CENA_OBIAD } from './data';
import Formularz from './components/Formularz';
import Podsumowanie from './components/Podsumowanie';

function App() {
  const [miejsce, setMiejsce] = useState('');
  const [ileOsob, setIleOsob] = useState('');
  const [wlasnyTransport, setWlasnyTransport] = useState(false);
  const [wyzywienie, setWyzywienie] = useState('');
  const [uwagi, setUwagi] = useState('');
  const [email, setEmail] = useState('');

  const obliczWartosc = () => {
    if (!miejsce || !ileOsob || !wyzywienie) return null;
    
    const n = parseInt(ileOsob);
    if (isNaN(n) || n <= 0) return null;
    
    const transport = wlasnyTransport ? 0 : TRANSPORT[miejsce];
    
    let jedzenie = 0;
    if (wyzywienie === 'sniadania') jedzenie = CENA_SNIADANIE;
    if (wyzywienie === 'pelne') jedzenie = CENA_OBIAD + 2 * CENA_SNIADANIE;
    
    return n * (transport + jedzenie);
  };

  const wartosc = obliczWartosc();
  const emailBlad = email !== '' && !email.includes('@');
  const imgSrc = miejsce ? ZDJECIA[miejsce] : DOMYSLNE_ZDJECIE;

  const handleSubmit = (e) => {
    e.preventDefault();
    if (!email || emailBlad) return;

    console.log({
      adresEm: email,
      dojazd: wlasnyTransport,
      miejsce: miejsce,
      ileOsob: parseInt(ileOsob),
      wyzywienie: wyzywienie,
      uwagi: uwagi || 'nie ma',
    });

    alert('Dziekujemy za zlozenie zamowienia, wszystkie informacje zostaly wyslane na adres: ' + email);
  };

  return (
    <div className="App">
      <h1 className="tytul">Zapraszamy na wycieczke Twoich marzen</h1>
      <h2 className="podtytul">Prosze podac dane:</h2>

      <div className="obrazek-wrapper">
        <img src={imgSrc} alt="grafika wycieczki" className="obrazek" />
      </div>

      <Formularz
        miejsce={miejsce} setMiejsce={setMiejsce}
        ileOsob={ileOsob} setIleOsob={setIleOsob}
        wlasnyTransport={wlasnyTransport} setWlasnyTransport={setWlasnyTransport}
        wyzywienie={wyzywienie} setWyzywienie={setWyzywienie}
        uwagi={uwagi} setUwagi={setUwagi}
        email={email} setEmail={setEmail}
        onSubmit={handleSubmit}
      />

      <Podsumowanie
        miejsce={miejsce}
        ileOsob={ileOsob}
        wlasnyTransport={wlasnyTransport}
        wyzywienie={wyzywienie}
        uwagi={uwagi}
        email={email}
        emailBlad={emailBlad}
        wartosc={wartosc}
      />
    </div>
  );
}

export default App;
