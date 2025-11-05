import './App.css';
import React, { useState } from 'react';

function App() {
  const [shoes] = useState([
    {
      id: 1,
      name: 'Buty sportowe Nike',
      image: '🏃',
      price: 299.99,
      category: 'sportowe',
      recommended: true
    },
    {
      id: 2,
      name: 'Buty eleganckie czarne',
      image: '👞',
      price: 399.99,
      category: 'eleganckie',
      recommended: true
    },
    {
      id: 3,
      name: 'Buty trekkingowe',
      image: '🥾',
      price: 349.99,
      category: 'sportowe',
      recommended: true
    },
    {
      id: 4,
      name: 'Buty casual Adidas',
      image: '👟',
      price: 279.99,
      category: 'sportowe',
      recommended: false
    },
    {
      id: 5,
      name: 'Buty wizytowe brązowe',
      image: '👞',
      price: 449.99,
      category: 'eleganckie',
      recommended: false
    },
    {
      id: 6,
      name: 'Kozaki zimowe',
      image: '🥾',
      price: 499.99,
      category: 'zimowe',
      recommended: false
    },
    {
      id: 7,
      name: 'Sandały letnie',
      image: '🩴',
      price: 149.99,
      category: 'letnie',
      recommended: false
    }
  ]);

  const [filterCategory, setFilterCategory] = useState('wszystkie');

  const recommendedShoes = shoes.filter(shoe => shoe.recommended);
  
  const myShoes = shoes.filter(shoe => !shoe.recommended);

  const filteredMyShoes = filterCategory === 'wszystkie' 
    ? myShoes 
    : myShoes.filter(shoe => shoe.category === filterCategory);

  return (
    <div className="App">
      <header className="header">
        <h1>Sklep z Butami</h1>
      </header>

      <section className="recommended-section">
        <h2>Polecamy buty firmy: Moje Obuwie</h2>
        <div className="shoes-grid">
          {recommendedShoes.map(shoe => (
            <div key={shoe.id} className="shoe-card">
              <div className="shoe-image">{shoe.image}</div>
              <h3>{shoe.name}</h3>
              <button className="buy-button">Kup teraz</button>
              <p className="price">{shoe.price.toFixed(2)} zł</p>
            </div>
          ))}
        </div>
      </section>

      <section className="my-shoes-section">
        <div className="section-header">
          <h2>Polecamy buty firmy: Moje Obuwie</h2>
          <div className="filter-buttons">
            <button 
              className={filterCategory === 'wszystkie' ? 'filter-btn active' : 'filter-btn'}
              onClick={() => setFilterCategory('wszystkie')}
            >
              Wszystkie
            </button>
            <button 
              className={filterCategory === 'sportowe' ? 'filter-btn active' : 'filter-btn'}
              onClick={() => setFilterCategory('sportowe')}
            >
              Sportowe
            </button>
            <button 
              className={filterCategory === 'eleganckie' ? 'filter-btn active' : 'filter-btn'}
              onClick={() => setFilterCategory('eleganckie')}
            >
              Eleganckie
            </button>
            <button 
              className={filterCategory === 'zimowe' ? 'filter-btn active' : 'filter-btn'}
              onClick={() => setFilterCategory('zimowe')}
            >
              Zimowe
            </button>
            <button 
              className={filterCategory === 'letnie' ? 'filter-btn active' : 'filter-btn'}
              onClick={() => setFilterCategory('letnie')}
            >
              Letnie
            </button>
          </div>
        </div>

        <div className="offers-container">
          <div className="offers-list">
            <h3>Nasza oferta:</h3>
            {filteredMyShoes.map(shoe => (
              <div key={shoe.id} className="offer-item">
                <span className="offer-image">{shoe.image}</span>
                <span className="offer-name">{shoe.name}</span>
                <button className="offer-button">Kup teraz</button>
              </div>
            ))}
          </div>

          <div className="current-offers">
            <h3>Obecne letnie:</h3>
            {filteredMyShoes.map(shoe => (
              <div key={shoe.id} className="current-offer-card">
                <div className="current-offer-image">{shoe.image}</div>
                <h4>{shoe.name}</h4>
                <button className="current-buy-button">Kup teraz</button>
                <p className="current-price">{shoe.price.toFixed(2)} zł</p>
              </div>
            ))}
          </div>
        </div>
      </section>
    </div>
  );
}

export default App;
