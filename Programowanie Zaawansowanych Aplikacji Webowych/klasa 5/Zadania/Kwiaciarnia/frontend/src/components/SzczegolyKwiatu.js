import { useEffect, useState } from 'react';
import { fetchFlowers, money } from '../narzedzia';
import { Link, useParams } from 'react-router-dom';
import useKoszyk from '../useKoszyk';

export default function SzczegolyKwiatu() {
  const { id } = useParams();
  const { koszyk, zapisz } = useKoszyk();
  const [product, setProduct] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState('');
  const [retry, setRetry] = useState(0);
  const [quantity, setQuantity] = useState(1);
  const [notice, setNotice] = useState('');

  useEffect(() => {
    let active = true;
    setLoading(true);
    setError('');
    setQuantity(1);
    setNotice('');
    fetchFlowers()
      .then((flowers) => {
        if (active) setProduct(flowers.find((flower) => String(flower.id) === id) || null);
      })
      .catch((requestError) => {
        if (active) setError(requestError instanceof TypeError
          ? 'Brak połączenia z serwerem. Spróbuj ponownie.'
          : requestError.message);
      })
      .finally(() => {
        if (active) setLoading(false);
      });

    return () => {
      active = false;
    };
  }, [id, retry]);

  if (loading) return <p role="status">Ładowanie produktu...</p>;
  if (error) return <div className="catalog-error"><p role="alert">{error}</p><button className="button button--primary" onClick={() => setRetry((value) => value + 1)}>Spróbuj ponownie</button></div>;
  if (!product) return <p className="empty-message">Nie znaleźliśmy tego produktu.</p>;

  const dodajDoKoszyka = () => {
    const amount = Number(quantity);
    if (!Number.isSafeInteger(amount) || amount < 1) {
      setNotice('Podaj prawidłową ilość.');
      return;
    }

    const nextQuantity = Math.min(99, (koszyk[product.id] || 0) + amount);
    if (zapisz({ ...koszyk, [product.id]: nextQuantity })) {
      setNotice(`${product.name} dodano do koszyka.`);
    } else {
      setNotice('Nie udało się zapisać koszyka.');
    }
  };

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
        <button className="button button--primary" onClick={dodajDoKoszyka}>Dodaj do koszyka <span aria-hidden="true">＋</span></button>
        <Link className="button button--quiet" to="/koszyk" target="_blank" rel="noopener noreferrer">Przejdź do koszyka ↗</Link>
      </div>
      {notice && <p className="notice notice--success" role="status">{notice}</p>}
    </div>
    <div className="product-note"><p>Informacja o kwiecie:</p><small>{product.detail || 'Brak dodatkowych informacji.'}</small></div>
  </section>;
}