function Podsumowanie({ miejsce, ileOsob, wlasnyTransport, wyzywienie, uwagi, email, emailBlad, wartosc }) {
  return (
    <div className="podsumowanie">
      <h2 className="podsumowanie-tytul">Dane do wyslania:</h2>
      <ol className="podsumowanie-lista">
        <li>miejscowosc: {miejsce || 'jeszcze nie wybrane'}</li>
        <li>ilosc osob: {ileOsob || 'brak danych'}</li>
        <li>dojazd: {wlasnyTransport ? 'wlasny' : 'organizator'}</li>
        <li>wyzywienie: {wyzywienie || 'jeszcze nie wybrane'}</li>
        <li>uwagi: {uwagi || 'nie ma uwag'}</li>
        <li>
          adres e-mail: {email || 'adres nie zostal podany'}
          {emailBlad && (
            <>
              <br />
              <span className="blad">blendy adres e-mali</span>
            </>
          )}
        </li>
        <li>
          aktualna wartosc wycieczki:{' '}
          {wartosc !== null ? wartosc : 'brak danych do obliczenia'}
        </li>
      </ol>
    </div>
  );
}

export default Podsumowanie;
