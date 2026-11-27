import { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import { API_URL, fetchFlowers, money } from '../narzedzia';
import useKoszyk from '../useKoszyk';
import DaneZamowienia from './DaneZamowienia';
import ProduktWKoszyku from './ProduktWKoszyku';

export default function StronaKoszyka() {
  const { koszyk, zapisz } = useKoszyk();
  const [products, setProducts] = useState([]);
  const [loading, setLoading] = useState(true);
  const [catalogError, setCatalogError] = useState('');
  const [retry, setRetry] = useState(0);
  const [notice, setNotice] = useState('');
  const [submitting, setSubmitting] = useState(false);
  const [orderComplete, setOrderComplete] = useState(false);
  const [orderEmail, setOrderEmail] = useState('');

  useEffect(() => {
    let active = true;
    setLoading(true);
    setCatalogError('');
    fetchFlowers()
      .then((flowers) => {
        if (active) setProducts(flowers);
      })
      .catch((error) => {
        if (active) setCatalogError(error instanceof TypeError
          ? 'Brak połączenia z serwerem. Spróbuj ponownie.'
          : error.message);
      })
      .finally(() => {
        if (active) setLoading(false);
      });

    return () => {
      active = false;
    };
  }, [retry]);

  const cartItems = products.filter((product) => koszyk[product.id] > 0);
  const itemCount = Object.values(koszyk).reduce((sum, quantity) => sum + quantity, 0);
  const total = cartItems.reduce(
    (sum, product) => sum + Math.round(product.price * 100) * koszyk[product.id],
    0
  ) / 100;

  const zmienIlosc = (id, value) => {
    if (value === '') return;
    const quantity = Math.min(99, Math.floor(Number(value)));
    if (!Number.isFinite(quantity) || quantity < 0) return;

    const nextCart = { ...koszyk };
    if (quantity === 0) delete nextCart[id];
    else nextCart[id] = quantity;
    if (!zapisz(nextCart)) setNotice('Nie udało się zapisać koszyka.');
  };

  const wyslijZamowienie = async (customer, payment) => {
    setNotice('');
    if (cartItems.length === 0) {
      setNotice('Koszyk jest pusty. Dodaj kwiaty przed złożeniem zamówienia.');
      return;
    }

    setSubmitting(true);
    try {
      const response = await fetch(`${API_URL}/api/orders`, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
          klient: {
            klImie: customer.firstName.trim(),
            klNazwisko: customer.lastName.trim(),
            ulica: customer.street.trim(),
            nrLokalu: customer.house.trim(),
            miejscowosc: customer.city.trim(),
            kod: customer.postal.trim(),
            telefon: customer.phone.trim(),
            poczta: customer.email.trim(),
          },
          platnosc: payment,
          pozycje: cartItems.map((product) => ({
            IDkwiat: product.id,
            ilosc: koszyk[product.id],
          })),
        }),
      });
      const result = await response.json();
      if (!response.ok) throw new Error(result.error || 'Nie udało się przyjąć zamówienia.');
      if (!zapisz({})) setNotice('Zamówienie przyjęto, ale nie udało się wyczyścić koszyka.');
      setOrderEmail(customer.email);
      setOrderComplete(true);
    } catch (error) {
      setNotice(error instanceof TypeError
        ? 'Brak połączenia z serwerem. Spróbuj ponownie.'
        : error.message);
    } finally {
      setSubmitting(false);
    }
  };

  if (orderComplete) {
    return <section className="order-success">
      <span className="success-mark">✓</span>
      <h1>Zamówienie zostało przyjęte do realizacji.</h1>
      <p>Proszę sprawdzić wiadomość na skrzynce pocztowej <strong>{orderEmail}</strong>.</p>
      {notice && <p className="notice notice--error" role="alert">{notice}</p>}
      <Link className="button button--primary" to="/">Wróć do kwiatów <span>↗</span></Link>
    </section>;
  }

  if (loading || catalogError) return <section className="cart-page">
    <div className="section-heading"><h1>Zawartość koszyka:</h1></div>
    {loading && <p role="status">Ładowanie koszyka...</p>}
    {catalogError && <div className="catalog-error"><p role="alert">{catalogError}</p><button className="button button--primary" onClick={() => setRetry((value) => value + 1)}>Spróbuj ponownie</button></div>}
  </section>;

  return <section className="cart-page">
    <div className="section-heading"><h1>Zawartość koszyka:</h1></div>
    {cartItems.length === 0 ? <div className="empty-cart">
      <p>Koszyk jest pusty.</p>
      <Link className="button button--primary" to="/">Wróć do zakupów <span>↗</span></Link>
    </div> : <div className="checkout-layout">
      <div className="cart-column">
        <div className="cart-list">
          {cartItems.map((product, index) => <ProduktWKoszyku
            key={product.id}
            product={product}
            index={index}
            quantity={koszyk[product.id]}
            onQuantityChange={zmienIlosc}
            onRemove={(id) => zmienIlosc(id, 0)}
          />)}
        </div>
        <div className="cart-total"><span>Do zapłaty <small>({itemCount} produktów)</small></span><strong>{money(total)}</strong></div>
      </div>
      <DaneZamowienia wyslij={wyslijZamowienie} blad={notice} wysylanie={submitting} />
    </div>}
  </section>;
}