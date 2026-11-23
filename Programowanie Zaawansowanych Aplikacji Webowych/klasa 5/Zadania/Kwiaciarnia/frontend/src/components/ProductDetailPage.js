import { useEffect, useState } from 'react';
import { money } from '../utils';

export default function ProductDetailPage({ product, loading, error, onRetry, onAddToCart, notice }) {
  const [quantity, setQuantity] = useState(1);

  useEffect(() => setQuantity(1), [product?.id]);

  if (loading) return <p role="status">Ładowanie produktu...</p>;
  if (error) return <div className="catalog-error"><p role="alert">{error}</p><button className="button button--primary" onClick={onRetry}>Spróbuj ponownie</button></div>;
  if (!product) return <p className="empty-message">Nie znaleźliśmy tego produktu.</p>;

  return <section className="product-detail">
    <div className="detail-image-wrap"><img className="detail-image" src={product.image} alt={product.name} /></div>
    <div className="detail-copy">
      <p className="eyebrow">Wybrany kwiat:</p>
      <h1>{product.name}</h1>
      <p className="detail-description">{product.detail}</p>
      <p className="detail-price">Cena: {money(product.price)}</p>
      <div className="detail-actions">
        <label className="detail-quantity">Ilość
          <span className="quantity-stepper">
            <button type="button" aria-label="Zmniejsz ilość" onClick={() => setQuantity(Math.max(1, Number(quantity) - 1))}>−</button>
            <input type="number" min="1" max="99" value={quantity} onChange={(event) => setQuantity(event.target.value)} />
            <button type="button" aria-label="Zwiększ ilość" onClick={() => setQuantity(Math.min(99, Number(quantity) + 1))}>+</button>
          </span>
        </label>
        <button className="button button--primary" onClick={() => onAddToCart(product, Number(quantity))}>Dodaj do koszyka <span aria-hidden="true">＋</span></button>
        <a className="button button--quiet" href="?view=cart" target="_blank" rel="noopener noreferrer">Przejdź do koszyka ↗</a>
      </div>
      {notice && <p className="notice notice--success" role="status">{notice}</p>}
    </div>
    <div className="product-note"><p>Informacja o kwiecie:</p><small>{product.detail || 'Brak dodatkowych informacji.'}</small></div>
  </section>;
}