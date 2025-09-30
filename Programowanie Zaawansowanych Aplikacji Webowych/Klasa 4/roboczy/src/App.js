import './App.css';
import data from './tabela.json';

const round2 = x => Math.round(x * 100) / 100;

function obliczWyniki(nazwa, wartosci) {
  if (!wartosci) return { pole: '-', objetosc: '-' };
  switch (nazwa) {
    case 'Sześcian': {
      const a = Number(wartosci.a);
      return { pole: 6 * a * a, objetosc: a ** 3 };
    }
    case 'Prostopadłościan': {
      const a = Number(wartosci.a), b = Number(wartosci.b), h = Number(wartosci.h);
      return { pole: 2 * (a*b + a*h + b*h), objetosc: a*b*h };
    }
    case 'Kula': {
      const r = Number(wartosci.r);
      return {
        pole: round2(4 * Math.PI * r * r),
        objetosc: round2((4/3) * Math.PI * r ** 3)
      };
    }
    default:
      return { pole: '-', objetosc: '-' };
  }
}

function App() {
  return (
    <div className="App">
      <h1>Bryły</h1>
      <table>
        <tr>
          <th>Bryła</th>
          <th>Ilustracja</th>
          <th>Wzory</th>
          <th>Przykład</th>
        </tr>
        {data.map((item) => {
          const { pole, objetosc } = obliczWyniki(item.nazwa, item.przyklad?.wymiary);
          return (
            <tr>
              <td>{item.nazwa}</td>
              <td><img src={item.ilustracja} alt={item.nazwa}/></td>
              <td>
                <p>Objetość: {item.wzory.objetosc}</p>
                <p>Pole: {item.wzory.pole}</p>
              </td>
              <td>
                {Object.entries(item.przyklad.wymiary).map(
                  ([klucz, wartosc]) => (
                  <p key={klucz} id='wymiar'>{klucz}: {wartosc}</p>
                ))}
                <p>Pole: {pole}</p>
                <p>Objetosc: {objetosc}</p>
              </td>
            </tr>
          );
        })}
      </table>
    </div>
  );
}

export default App;
