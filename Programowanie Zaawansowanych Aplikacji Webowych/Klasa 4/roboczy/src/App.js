import './App.css';
import React, { useState } from 'react';
import Header from './naglowek/Header';
import Footer from './stopka/Footer';
import WyswietlOferty from './cialo strony/wyswietlOferty';
import { summerShoes as summerShoesData, winterShoes as winterShoesData } from './data/shoesData';

function App() {
  const [summerShoes] = useState(summerShoesData.map(shoe => ({ ...shoe, id: crypto.randomUUID() })));
  const [winterShoes] = useState(winterShoesData.map(shoe => ({ ...shoe, id: crypto.randomUUID() })));
  const [displayedShoes, setDisplayedShoes] = useState([]);

  function obuwieLetnie(){
    setDisplayedShoes(prevShoes => {
      const newShoes = summerShoes.filter(summerShoe => 
        !prevShoes.some(displayedShoe => displayedShoe.id === summerShoe.id)
      ).slice(0, 2);
      return [...prevShoes, ...newShoes];
    });
  }
  function obuwieZimowe() {
    setDisplayedShoes(prevShoes => {
      const newShoes = winterShoes.filter(winterShoe => 
        !prevShoes.some(displayedShoe => displayedShoe.id === winterShoe.id)
      );
      return [...prevShoes, ...newShoes];
    });
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
            <WyswietlOferty 
              shoes={displayedShoes} 
              onSprzedaz={handleSprzedaz} 
              onPrzyjecie={handlePrzyjecie}/>
          </div>
      </section>
      <Footer />
    </div>
  );
}

export default App;
