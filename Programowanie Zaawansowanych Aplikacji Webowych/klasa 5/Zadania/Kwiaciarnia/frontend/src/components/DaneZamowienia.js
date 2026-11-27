import { useState } from 'react';

const pola = [
  ['firstName', 'Imię', 30],
  ['lastName', 'Nazwisko', 30],
  ['street', 'Ulica', 30],
  ['house', 'Numer domu / lokalu', 10],
  ['city', 'Miejscowość', 60],
  ['postal', 'Kod pocztowy', 10],
  ['phone', 'Telefon', 20],
  ['email', 'Adres e-mail', 50],
];

const pustyKlient = Object.fromEntries(pola.map(([klucz]) => [klucz, '']));

export default function DaneZamowienia({ wyslij, blad, wysylanie }) {
  const [klient, setKlient] = useState(pustyKlient);
  const [platnosc, setPlatnosc] = useState('');
  const [bladFormularza, setBladFormularza] = useState('');

  const wyslijFormularz = (event) => {
    event.preventDefault();
    const dane = Object.fromEntries(
      Object.entries(klient).map(([klucz, wartosc]) => [klucz, wartosc.trim()])
    );

    if (Object.values(dane).some((wartosc) => !wartosc)) {
      setBladFormularza('Proszę uzupełnić wszystkie dane osobowe i adresowe.');
      return;
    }
    if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(dane.email)) {
      setBladFormularza('Proszę podać poprawny adres e-mail.');
      return;
    }
    if (!platnosc) {
      setBladFormularza('Proszę wybrać sposób płatności.');
      return;
    }

    setBladFormularza('');
    wyslij(dane, platnosc);
  };

  return <form className="order-form" onSubmit={wyslijFormularz} noValidate>
    <h2>Informacje o realizacji zamówienia:</h2>
      <label className="form-label">Sposób płatności
        <select value={platnosc} onChange={(event) => setPlatnosc(event.target.value)}>
          <option value="">Wybierz płatność</option>
          <option value="Stripe">Stripe</option>
          <option value="przelew on line">przelew on line</option>
          <option value="PayPal">PayPal</option>
          <option value="Karta Kredytowa">Karta Kredytowa</option>
        </select>
      </label>
      <div className="form-grid">
        {pola.map(([klucz, etykieta, limit]) => <label className="form-label" key={klucz}>{etykieta}
          <input
            required
            maxLength={limit}
            type={klucz === 'email' ? 'email' : klucz === 'phone' ? 'tel' : 'text'}
            value={klient[klucz]}
            onChange={(event) => setKlient({ ...klient, [klucz]: event.target.value })}
          />
        </label>)}
      </div>
      {(bladFormularza || blad) && <p className="notice notice--error" role="alert">{bladFormularza || blad}</p>}
      <button className="button button--primary submit-button" type="submit" disabled={wysylanie}>
        {wysylanie ? 'Wysyłanie…' : 'Wyślij zamówienie'} <span aria-hidden="true">↗</span>
      </button>
  </form>;
}
