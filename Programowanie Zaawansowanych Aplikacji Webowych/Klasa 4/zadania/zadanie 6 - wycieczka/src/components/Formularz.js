import { MIEJSCA_LISTA } from '../data';

function Formularz({ miejsce, setMiejsce, ileOsob, setIleOsob, wlasnyTransport, setWlasnyTransport, wyzywienie, setWyzywienie, uwagi, setUwagi, email, setEmail, onSubmit }) {
  return (
    <form onSubmit={onSubmit}>
      <div className="wiersz">
        <strong>miejsce prosze wybrac z listy:</strong>
        <select value={miejsce} onChange={(e) => setMiejsce(e.target.value)}>
          <option value="">--</option>
          <option value={MIEJSCA_LISTA[0]}>{MIEJSCA_LISTA[0]}</option>
          <option value={MIEJSCA_LISTA[1]}>{MIEJSCA_LISTA[1]}</option>
          <option value={MIEJSCA_LISTA[2]}>{MIEJSCA_LISTA[2]}</option>
        </select>
      </div>

      <div className="wiersz">
        <strong>ilosc osob:</strong>
        <input
          type="number"
          value={ileOsob}
          onChange={(e) => setIleOsob(e.target.value)}
          min="1"
        />
      </div>

      <div className="wiersz">
        <strong>prosze zaznaczyc w przypadku wlasnego transportu:</strong>
        <input
          type="checkbox"
          checked={wlasnyTransport}
          onChange={(e) => setWlasnyTransport(e.target.checked)}
        />
      </div>

      <div className="sekcja">
        <strong>prosze zaznaczyc sposob wyzywienia:</strong>
        <ul className="radio-lista">
          <li>
            <label>
              wlasne
              <input
                type="radio"
                name="wyzywienie"
                value="wlasne"
                checked={wyzywienie === 'wlasne'}
                onChange={(e) => setWyzywienie(e.target.value)}
              />
            </label>
          </li>
          <li>
            <label>
              sniadania
              <input
                type="radio"
                name="wyzywienie"
                value="sniadania"
                checked={wyzywienie === 'sniadania'}
                onChange={(e) => setWyzywienie(e.target.value)}
              />
            </label>
          </li>
          <li>
            <label>
              pelne
              <input
                type="radio"
                name="wyzywienie"
                value="pelne"
                checked={wyzywienie === 'pelne'}
                onChange={(e) => setWyzywienie(e.target.value)}
              />
            </label>
          </li>
        </ul>
      </div>

      <div className="sekcja">
        <strong>Uwagi do organizatora:</strong>
        <br />
        <textarea
          value={uwagi}
          onChange={(e) => setUwagi(e.target.value)}
          rows={3}
          cols={50}
        />
      </div>

      <div className="wiersz">
        <strong>adres do wyslania oferty:</strong>
        <input
          type="text"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />
      </div>

      <button type="submit" className="btn-wysylaj">wyslij zamowienie</button>
    </form>
  );
}

export default Formularz;
