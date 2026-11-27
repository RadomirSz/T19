import { useEffect, useState } from 'react';
import KartaKwiatu from './KartaKwiatu';
import { fetchFlowers } from '../narzedzia';

export default function StronaGlowna() {
  const [products, setProducts] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState('');
  const [retry, setRetry] = useState(0);

  useEffect(() => {
    let active = true;
    setLoading(true);
    setError('');
    fetchFlowers()
      .then((flowers) => {
        if (active) setProducts(flowers);
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
  }, [retry]);

  return <section className="shop-section" id="oferta">
    <h2 className="offer-title">Nasza oferta:</h2>
    {loading && <p role="status">Ładowanie kwiatów...</p>}
    {error && <div className="catalog-error"><p role="alert">{error}</p><button className="button button--primary" onClick={() => setRetry((value) => value + 1)}>Spróbuj ponownie</button></div>}
    <div className="product-grid">
      {!loading && !error && products.map((product, index) => <KartaKwiatu key={product.id} product={product} index={index} />)}
    </div>
    {!loading && !error && products.length === 0 && <p className="empty-message">Brak kwiatów w ofercie.</p>}
  </section>;
}