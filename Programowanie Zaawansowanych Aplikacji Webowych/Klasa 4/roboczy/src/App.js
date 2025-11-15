import './App.css';
import React, { useState } from 'react';
import Header from './naglowek/Header';
import Footer from './stopka/Footer';
import WyswietlOferty from './cialo strony/wyswietlOferty';
import { summerShoes as summerShoesData, winterShoes as winterShoesData } from './data/shoesData';

function App() {
  const [summerShoes, setSummerShoes] = useState(summerShoesData.map(shoe => ({ ...shoe, id: crypto.randomUUID() })));
  const [winterShoes, setWinterShoes] = useState(winterShoesData.map(shoe => ({ ...shoe, id: crypto.randomUUID() })));
  const [displayedShoes, setDisplayedShoes] = useState([]);

  function obuwieLetnie(){
    setDisplayedShoes(prevShoes => [...prevShoes, ...summerShoes]);
  }
  function obuwieZimowe() {
    setDisplayedShoes(prevShoes => [...prevShoes, ...winterShoes]);
  }
  function usunWyprzedane() {
    setDisplayedShoes(prevShoes => prevShoes.filter(shoe => shoe.stock > 0));
  }
  function handleSprzedaz(shoeId) {
    setDisplayedShoes(prevShoes => 
      prevShoes.map(shoe => 
        shoe.id === shoeId && shoe.stock > 0 ? { ...shoe, stock: shoe.stock - 1 } : shoe
      )
    );
  }
  function handlePrzyjecie(shoeId, ilosc) {
    setDisplayedShoes(prevShoes => 
      prevShoes.map(shoe => 
        shoe.id === shoeId ? { ...shoe, stock: Number(shoe.stock) + Number(ilosc) } : shoe
      )
    );
  }
  
  return (
    <div className="App">
      <section className="recommended-section">
        <Header nazwa="Moje Obowie"/>
        <div className='header-buttons'>
          <button onClick={obuwieLetnie}>Przyjmij obuwie letnie</button>
          <button onClick={obuwieZimowe}>Przyjmij obuwie zimowe</button>
          <button onClick={usunWyprzedane}>Usun wyprzedane</button>
        </div>
      </section>

      <section className="my-shoes-section">
          <div className="offers">
            <WyswietlOferty shoes={displayedShoes} onSprzedaz={handleSprzedaz} onPrzyjecie={handlePrzyjecie}/>
          </div>
      </section>
      <Footer />
    </div>
  );
}

export default App;
