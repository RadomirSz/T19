import './App.css';
import React, { useState } from 'react';
import Header from './naglowek/Header';
import Footer from './stopka/Footer';
import WyswietlOferty from './cialo strony/wyswietlOferty';
import { summerShoes as summerShoesData, winterShoes as winterShoesData } from './data/shoesData';

function App() {
  const [summerShoes, setSummerShoes] = useState(summerShoesData);
  const [winterShoes, setWinterShoes] = useState(winterShoesData);

  function obuwieLetnie(){

  }
  function obuwieZimowe() {
    
  }
  function usunWyprzedane() {
    
  }
  return (
    <div className="App">
      <section className="recommended-section">
        <Header nazwa="Moje Obowie"/>
        <div className='header-buttons'>
          <button onClick={obuwieLetnie()}>Przyjmij obuwie letnie</button>
          <button onClick={obuwieZimowe()}>Przyjmij obuwie zimowe</button>
          <button onClick={usunWyprzedane()}>Usun wyprzedane</button>
        </div>
      </section>

      <section className="my-shoes-section">
          <div className="offers">
            <WyswietlOferty shoes={summerShoes}/>
            <WyswietlOferty shoes={winterShoes}/>
          </div>
      </section>
      <Footer />
    </div>
  );
}

export default App;
