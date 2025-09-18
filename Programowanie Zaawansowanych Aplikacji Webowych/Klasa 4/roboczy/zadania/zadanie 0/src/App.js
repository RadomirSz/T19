import logo from './logo.svg';
import './App.css';

function Witaj() {
  let osoba = prompt("jak masz na imie?");
  let naziwsko = prompt("jak masz na naziwsko?");
  return <p className='App-p'>witaj {osoba} {naziwsko}</p>;
}

function SumaFu() {
  let start = parseInt(prompt("pierwszy"));
  let stop = parseInt(prompt("ostatni"));
  let step = parseInt(prompt("krok"));
  
  let elem = ""
  let suma = 0

  for (let i = start; i <= stop; i += step) {
    elem += i+"+"
    suma += i
  }

  elem = elem+0+"="+suma;

  return <p className='App-p'>Suma ciągu: {elem}</p>
}
function App() {
  return (
    <div>
      <h2>Hemlo word!</h2>
      <Witaj />
      <SumaFu />
    </div>
  );
}

export default App;
