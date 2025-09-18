
import './App.css';
import obrazekFib from './fibonacci.jpg';
function CiagFib() {
  let n = prompt("iloczyn ilu wyrazów powinien obliczyć porgram?");

  let iloczyn = 1;
  let liczbaA = 1;
  let liczbaB = 1;
  let ciag = "";
  for (let i = 1; i <= n; i++) {
    iloczyn *= liczbaA;
    ciag += i!=n ? liczbaA + " * " : liczbaA;
    let liczba = liczbaA + liczbaB;
    liczbaA = liczbaB;
    liczbaB = liczba;
  }
  return <div><p>Iloczyn {n} pierwszych wyrazów ciągu Fibonacciego to:</p><p>{ciag} = {iloczyn}</p></div>
}
function App() {
  return (
    <div>
      <h1>Obliczanie iloczynu n elementów ciągu Fibonacciego</h1>
      <img src={obrazekFib}/>
      <CiagFib />
    </div>
    
  );
}

export default App;
