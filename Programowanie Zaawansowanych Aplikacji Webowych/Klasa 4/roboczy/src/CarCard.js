import React from 'react';

const CarCard = ({ car }) => {
  return (
    <div className="car-card">
      <img src={car.image} alt={`${car.brand} ${car.model}`} className="car-image" />
      <div className="car-info">
        <h3 className="car-title">{car.brand} {car.model}</h3>
        <p className="car-year">Rok: {car.year}</p>
        <p className="car-price">{car.price}</p>
        <button className="contact-btn">Kontakt</button>
      </div>
    </div>
  );
};

export default CarCard;