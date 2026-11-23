import { useState } from 'react';

const pola = [
  ['klImie', 'Imię', 30], 
  ['klNazwisko', 'Nazwisko', 30], 
  ['ulica', 'Ulica', 30],
  ['nrLokalu', 'numer domu', 10], 
  ['miejscowosc', 'miejscowość', 60],
  ['kod', 'kod', 10], 
  ['telefon', 'telefon', 20],
  ['poczta', 'adres e-mail', 50],
];

function FormularzZamowienia({ wyslij, wysylanie }) {
  const [klient, setKlient] = useState(Object.fromEntries(pola.map(([klucz]) => [klucz, ''])));
  const [platnosc, setPlatnosc] = useState('');
  const [blad, setBlad] = useState('');
  return (
    <section className="realizacja-zamowienia">
      <h2>Informacje o realizacji<br />zamówienia:</h2>
      <form noValidate onSubmit={(event) => {
        event.preventDefault();
        const dane = Object.fromEntries(Object.entries(klient).map(([klucz, wartosc]) => [klucz, wartosc.trim()]));
        if (Object.values(dane).some((wartosc) => !wartosc)) {
          setBlad('Proszę uzupełnić wszystkie dane osobowe.'); window.alert('Proszę uzupełnić wszystkie dane osobowe.'); return;
        }
        if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(dane.poczta)) {
          setBlad('Proszę podać poprawny adres e-mail.'); window.alert('Proszę podać poprawny adres e-mail.'); return;
        }
        if (!platnosc) { setBlad('Proszę wybrać sposób płatności.'); window.alert('Zamówienie nie opłacone, proszę opłacić zamówienie.'); return; }
        setBlad('');
        wyslij(dane, platnosc);
      }}>
        <fieldset disabled={wysylanie}>
          <label htmlFor="platnosc">Proszę wybrać sposób płatności:</label>
          <select id="platnosc" value={platnosc} onChange={(event) => setPlatnosc(event.target.value)} required>
            <option value="">-----</option>
            <option value="Stripe">Stripe</option>
            <option value="przelew on line">przelew on line</option>
            <option value="PayPal">PayPal</option>
            <option value="Karta Kredytowa">Karta Kredytowa</option>
          </select>
          <h3>Proszę podać dane do wysyłki:</h3>
          {pola.map(([klucz, etykieta, limit]) => (
            <div className="pole-formularza" key={klucz}>
              <label htmlFor={klucz}>{etykieta}:</label>
              <input id={klucz} name={klucz} maxLength={limit} required
                type={klucz === 'poczta' ? 'email' : klucz === 'telefon' ? 'tel' : 'text'}
                value={klient[klucz]} onChange={(event) => setKlient({ ...klient, [klucz]: event.target.value })}
              />
            </div>
          ))}
          {blad && <p role="alert" className="tylko-czytnik">{blad}</p>}
          <button type="submit">{wysylanie ? 'Wysyłanie...' : 'wyślij zamówienie'}</button>
        </fieldset>
      </form>
    </section>
  );
}

export default FormularzZamowienia;

