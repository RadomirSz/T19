import { useEffect, useState } from 'react';
import { money } from '../narzedzia';

export default function ProduktWKoszyku({ product, index, quantity, onQuantityChange, onRemove }) {
  const [ilosc, setIlosc] = useState(quantity);

  useEffect(() => setIlosc(quantity), [quantity]);

  return <article className="cart-row">
    <span className="cart-index">0{index + 1}</span>
    <img src={product.image} alt="" />
    <div className="cart-product-info">
      <h2>{product.name}</h2>
      <p>{money(product.price)} / szt.</p>
      <button className="text-button" onClick={() => onRemove(product.id)}>Usuń</button>
    </div>
    <label className="quantity-control">
      <span>Ilość</span>
      <input
        aria-label={`Ilość: ${product.name}`}
        type="number"
        min="1"
        max="99"
        value={ilosc}
        onChange={(event) => {
          const value = event.target.value;
          setIlosc(value);
          if (value !== '' && Number(value) > 0) onQuantityChange(product.id, value);
        }}
        onBlur={() => setIlosc(quantity)}
      />
    </label>
    <strong className="line-total">{money(product.price * quantity)}</strong>
  </article>;
}
