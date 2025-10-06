import './App.css';

function FormatNapisu(text){
  return text.toLowerCase().charAt(0).toUpperCase()+text.slice(1).toLowerCase();
}


function UtworyDruk(dzielo){
  return dzielo.utwory[0].tytul
}


function GatunekLiter(gatunek){
  return gatunek.utwory[0].rodzaj
}


const pisarze = [
{"id":0,"imie":"adam","nazwisko":"mickiewicz","kraj":"polska",
  "utwory":[
    {"id":0,"tytul":"Pan Tadeusz","rodzaj":"epika"},
    {"id":1,"tytul":"Ballady i romanse","rodzaj":"liryka"},
    {"id":2,"tytul":"Dziady","rodzaj":"dramat"}
  ]
},
{"id":1,"imie":"jan", "nazwisko":"kochanowski","kraj":"polska",
 "utwory":[
  {"id":0,"tytul":"Odprawa poslow greckich","rodzaj":"dramat"},
  {"id":1,"tytul":"Fraszki","rodzaj":"liryka"}
 ]
},
{"id":2,"imie":"wiliam","nazwisko":"shakespeare","kraj":"anglia",
 "utwory":[
  {"id":0,"tytul":"Hamlet","rodzaj":"dramat"},
  {"id":1,"tytul":"Romeo i Julia","rodzaj":"dramat"},
  {"id":2,"tytul":"Juliusz Cezar","rodzaj":"dramat"}
 ]
},
{"id":3,"imie":"isaak","nazwisko":"asimow","kraj":"stany zjednoczone",
 "utwory":[
  {"id":0,"tytul":"Ja, robot", "rodzaj":"epika"},
  {"id":1,"tytul":"Koniec wiecznosci","rodzaj":"epika"}
 ]

}
];

function App() {
  return (
    <div className="App">
      <table cellpadding="0" cellspacing="0">
        <thead>
          <tr>
            <th>AUTOR</th>
            <th>KRAJ</th>
            <th>UTWORY</th>
          </tr>
        </thead>
        <tbody>
          {pisarze.map((item,index)=>(
          <tr key ={item.id}>
            <td><b><i>{FormatNapisu(pisarze[index].imie)} {FormatNapisu(item.nazwisko)}</i></b></td>
            <td>{item.kraj.toUpperCase()}</td>
            <td>
              <ol>
              {item.utwory.map((itemW,indexW)=>(
                  <li key={itemW.id}><b>{pisarze[index].utwory[indexW].tytul}</b> to {pisarze[index].utwory[indexW].rodzaj}</li>
              ))}
              </ol>
              FUNKCJA UtworyDruk: {UtworyDruk(item)} FUNKCJA GatunekLiter: {GatunekLiter(item)}
            </td>
          </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default App;
