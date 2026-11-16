import { useEffect, useState } from 'react';
import './App.css';

function App() {
  const [ksiazki, setKsiazki] = useState([]);
  const [blad, setBlad] = useState('');

  useEffect(() => {
    fetch('http://localhost:3100/api/books')
      .then((response) => {
        if (!response.ok) {
          throw new Error('Nie udało się pobrać książek');
        }
        return response.json();
      })
      .then((data) => setKsiazki(data))
      .catch((error) => setBlad(error.message));
  }, []);

  return (
    <div className="App">
      <h3>Nasza oferta</h3>

      {blad && <p>{blad}</p>}

      <table>
        <thead>
          <tr>
            <th>Tytuł</th>
            <th>Cena</th>
            <th>Okładka</th>
          </tr>
        </thead>

        <tbody>
          {ksiazki.map((ksiazka) => (
            <tr key={ksiazka.IDksiazka}>
              <td>{ksiazka.tytul}</td>
              <td>{ksiazka.cena} zł</td>
              <td>
                <img
                  src={`http://localhost:3100/api/images/grafika/${ksiazka.IDksiazka}/okladka.jpg`}
                  alt={ksiazka.tytul}
                  width="150"
                />
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default App;