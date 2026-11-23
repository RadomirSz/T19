import './App.css';
import { useEffect, useState } from 'react';
import CartPage from './components/CartPage';
import HomePage from './components/HomePage';
import ProductDetailPage from './components/ProductDetailPage';
import SiteFooter from './components/SiteFooter';
import SiteHeader from './components/SiteHeader';
import { API_URL, cartKey, readCart } from './utils';

const emptyCustomer = {
  firstName: '',
  lastName: '',
  street: '',
  house: '',
  city: '',
  postal: '',
  phone: '',
  email: '',
};

function mapFlower(flower) {
  const id = Number(flower.IDkwiat);
  const price = Number(flower.cena);
  if (!Number.isSafeInteger(id) || !Number.isFinite(price)) return null;

  return {
    id,
    name: String(flower.nazwa || '').trim(),
    price,
    detail: String(flower.notatka || '').trim(),
    image: `${API_URL}/api/images/${id}/kwiat.jpg`,
  };
}

function App() {
  const [products, setProducts] = useState([]);
  const [loading, setLoading] = useState(true);
  const [catalogError, setCatalogError] = useState('');
  const [reload, setReload] = useState(0);
  const [cart, setCart] = useState(readCart);
  const [notice, setNotice] = useState('');
  const [payment, setPayment] = useState('');
  const [customer, setCustomer] = useState(emptyCustomer);
  const [submitting, setSubmitting] = useState(false);
  const [orderComplete, setOrderComplete] = useState(false);

  useEffect(() => {
    let active = true;
    setLoading(true);
    setCatalogError('');
    fetch(`${API_URL}/api/flowers`)
      .then(async (response) => {
        const data = await response.json();
        if (!response.ok) throw new Error(data.error || 'Nie udało się pobrać kwiatów.');
        if (!Array.isArray(data)) throw new Error('Serwer zwrócił nieprawidłowe dane.');
        return data.map(mapFlower).filter(Boolean);
      })
      .then((flowers) => {
        if (active) setProducts(flowers);
      })
      .catch((error) => {
        if (active) {
          setCatalogError(error instanceof TypeError
            ? 'Brak połączenia z serwerem. Spróbuj ponownie.'
            : error.message);
        }
      })
      .finally(() => {
        if (active) setLoading(false);
      });

    const syncCart = () => setCart(readCart());
    window.addEventListener('storage', syncCart);
    window.addEventListener('hortensja-cart-change', syncCart);
    return () => {
      active = false;
      window.removeEventListener('storage', syncCart);
      window.removeEventListener('hortensja-cart-change', syncCart);
    };
  }, [reload]);

  const saveCart = (nextCart) => {
    try {
      localStorage.setItem(cartKey, JSON.stringify(nextCart));
      setCart(nextCart);
      window.dispatchEvent(new Event('hortensja-cart-change'));
      return true;
    } catch {
      setNotice('Nie udało się zapisać koszyka.');
      return false;
    }
  };

  const addToCart = (product, quantity = 1) => {
    const amount = Number(quantity);
    if (!Number.isSafeInteger(amount) || amount < 1) return;
    const currentCart = readCart();
    const nextQuantity = Math.min(99, (currentCart[product.id] || 0) + amount);
    if (saveCart({ ...currentCart, [product.id]: nextQuantity })) {
      setNotice(`${product.name} dodano do koszyka.`);
    }
  };

  const changeQuantity = (id, value) => {
    if (value === '') return;
    const quantity = Math.min(99, Math.floor(Number(value)));
    if (!Number.isFinite(quantity) || quantity < 0) return;
    const nextCart = { ...cart };
    if (quantity === 0) delete nextCart[id];
    else nextCart[id] = quantity;
    saveCart(nextCart);
  };

  const cartItems = products.filter((product) => cart[product.id] > 0);
  const itemCount = Object.values(cart).reduce((sum, quantity) => sum + Number(quantity || 0), 0);
  const total = cartItems.reduce(
    (sum, product) => sum + Math.round(product.price * 100) * cart[product.id],
    0
  ) / 100;
  const params = new URLSearchParams(window.location.search);
  const view = params.get('view');
  const selectedProduct = products.find((product) => String(product.id) === params.get('id'));

  const submitOrder = async (event) => {
    event.preventDefault();
    setNotice('');
    if (Object.values(customer).some((value) => !value.trim())) {
      setNotice('Proszę uzupełnić wszystkie dane osobowe i adresowe.');
      return;
    }
    if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(customer.email.trim())) {
      setNotice('Proszę podać poprawny adres e-mail.');
      return;
    }
    if (!payment) {
      setNotice('Proszę wybrać sposób płatności.');
      return;
    }
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
            ilosc: cart[product.id],
          })),
        }),
      });
      const result = await response.json();
      if (!response.ok) throw new Error(result.error || 'Nie udało się przyjąć zamówienia.');
      if (!saveCart({})) setNotice('Zamówienie przyjęto, ale nie udało się wyczyścić koszyka.');
      setOrderComplete(true);
    } catch (error) {
      setNotice(error instanceof TypeError
        ? 'Brak połączenia z serwerem. Spróbuj ponownie.'
        : error.message);
    } finally {
      setSubmitting(false);
    }
  };

  const header = (compact = false) => <SiteHeader compact={compact} image={products[0]?.image} />;

  const footer = () => <SiteFooter image={products[0]?.image} />;

  if (view === 'product') {
    return <main className="page-shell popup-shell">
      {header(true)}
      <ProductDetailPage
        product={selectedProduct}
        loading={loading}
        error={catalogError}
        onRetry={() => setReload((count) => count + 1)}
        onAddToCart={addToCart}
        notice={notice}
      />
      {footer()}
    </main>;
  }

  if (view === 'cart') {
    return <main className="page-shell popup-shell">
      {header(true)}
      <CartPage
        cart={cart}
        cartItems={cartItems}
        customer={customer}
        itemCount={itemCount}
        notice={notice}
        loading={loading}
        catalogError={catalogError}
        onRetry={() => setReload((count) => count + 1)}
        onChangeQuantity={changeQuantity}
        onCustomerChange={(field, value) => setCustomer({ ...customer, [field]: value })}
        onPaymentChange={setPayment}
        onSubmitOrder={submitOrder}
        orderComplete={orderComplete}
        payment={payment}
        submitting={submitting}
        total={total}
      />
      {footer()}
    </main>;
  }

  return <main className="page-shell">
    {header()}
    <HomePage
      products={products}
      loading={loading}
      error={catalogError}
      onRetry={() => setReload((count) => count + 1)}
    />
    {footer()}
    {notice && <div className="toast" role="status">{notice}</div>}
  </main>;
}

export default App;
