import './App.css';
const list = [
{"imie":"adam","nazwisko":"KOWALSKI","wiek":"33"},
{"imie":"ALA", "nazwisko":"nowak","wiek":"32"},
{"imie":"Ola","nazwisko":"SteFAnowska","wiek":"4"}
];

function App() {
  return (
    <div className="App">
      <table cellpadding="0" cellspacing="0">
        <tr>
          <th>IMIE</th>
          <th>NAZWISKO</th>
          <th>WIEK</th>
        </tr>
        <tr>
          <td>{list[0].imie}</td>
          <td>{list[0].nazwisko}</td>
          <td>{list[0].wiek}</td>
        </tr>
        <tr>
          <td>{list[1].imie}</td>
          <td>{list[1].nazwisko}</td>
          <td>{list[1].wiek}</td>
        </tr>
        <tr>
          <td>{list[2].imie}</td>
          <td>{list[2].nazwisko}</td>
          <td>{list[2].wiek}</td>
        </tr>
      </table>
    </div>
  );
}

export default App;
