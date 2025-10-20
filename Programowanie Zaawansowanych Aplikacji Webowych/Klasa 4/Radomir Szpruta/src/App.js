import React, { useState } from "react";
import "./App.css";

function App() {
  const [rosliny] = useState([
    {
      id: 1,
      kategoria: "Kwiaty",
      rodzaj: "Polne",
      gatunek: ["mak", "rumianek"],
      obraz: "kwiaty.png"
    },
    {
      id: 2,
      kategoria: "Drzewa",
      rodzaj: "Liściaste",
      gatunek: ["dąb", "buk"],
      obraz: "drzewo.png"
    }
  ]);

  return (
    <div className="app-root">
      <main>
        <h1 className="App-header">Moje rośliny</h1>
        <table className="tabelka">
          <thead>
            <tr>
              <th>Lp</th>
              <th>Roślina</th>
              <th>Rodzaj</th>
              <th>Obrazek</th>
            </tr>
          </thead>
          <tbody>
            {rosliny.map((p, index) => (
              <tr key={p.id}>
                <td>{index + 1}</td>
                <td>
                  {p.kategoria}
                </td>
                <td>{p.rodzaj}
                  <ul>
                    {p.gatunek.map((s,index) => (
                      <li key={index}>{s}</li>
                    ))}
                  </ul>
                </td>
                <td><img src={p.obraz} alt={p.kategoria} className="obraz"/></td>
              </tr>
            ))}
          </tbody>
        </table>
      </main>
    </div>
  );
}

export default App;