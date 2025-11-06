import './App.css';
import React, { useState } from 'react';
import Header from './naglowek/Header';
import Footer from './stopka/Footer';
import Oferta from './oferty/oferta';

function App() {
  const [shoes] = useState([
    {
      id: 1,
      name: 'Nike ari froce',
      image: './resources/nike-shoes.png',
      price: 399.99,
      category: 'sportowe',
      stock: 14
    },
    {
      id: 2,
      name: 'Buty eleganckie czarne',
      image: './resources/wojas-shoes.png',
      price: 499.99,
      category: 'eleganckie',
      stock: 7
    },
    {
      id: 3,
      name: 'Buty trekkingowe',
      image: './resources/regatta-shoes.png',
      price: 349.99,
      category: 'sportowe',
      stock: 21
    },
    // {
    //   id: 4,
    //   name: 'Buty casual Adidas',
    //   image: '👟',
    //   price: 279.99,
    //   category: 'sportowe',
    //   recommended: false
    // },
    // {
    //   id: 5,
    //   name: 'Buty wizytowe brązowe',
    //   image: '👞',
    //   price: 449.99,
    //   category: 'eleganckie',
    //   recommended: false
    // },
    // {
    //   id: 6,
    //   name: 'Kozaki zimowe',
    //   image: '🥾',
    //   price: 499.99,
    //   category: 'zimowe',
    //   recommended: false
    // },
    // {
    //   id: 7,
    //   name: 'Sandały letnie',
    //   image: '🩴',
    //   price: 149.99,
    //   category: 'letnie',
    //   recommended: false
    // }
  ]);

  const [filterCategory, setFilterCategory] = useState('wszystkie');

  const recommendedShoes = shoes.filter(shoe => shoe.recommended);
  
  const myShoes = shoes.filter(shoe => !shoe.recommended);

  const filteredMyShoes = filterCategory === 'wszystkie' 
    ? myShoes 
    : myShoes.filter(shoe => shoe.category === filterCategory);

  return (
    <div className="App">
      

      <section className="recommended-section">
        <Header recommended="Moje Obowie"/>
        <div className="shoes-grid">
          
        </div>
      </section>

      <section className="my-shoes-section">
          <div className="offers">
            { shoes.map(shoe => (
              <Oferta shoe={shoe}/>
            ))} 
          </div>
      </section>
      <Footer />
    </div>
  );
}

export default App;
