import './App.css';
import { useEffect, useState } from 'react';

function App() {

  const [autorzy, setAutorzy] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(()=>{
    fetch('https://localhost:3100/api/data')
    .then( (resp) =>{
      resp.json()
    })
    .then((json_data)=>{
      console.log("data: ", json_data.wynik);
      setAutorzy(json_data.wynik)
      setLoading(false)
    })
    .catch((e) => console.log(e))
  },[]);

  if (loading) {
    return <p> Loading...</p>;
  }
  return (
    <div className="App">
      <h3>odp od serwera</h3>
      
      <ol>
        {autorzy.map((autor, index)=>(
          <li key={autor.IDautor}>
            {autor.imie} {autor.nazwisko}
          </li>
        ))}
      </ol>
    </div>
  );
}

export default App;
