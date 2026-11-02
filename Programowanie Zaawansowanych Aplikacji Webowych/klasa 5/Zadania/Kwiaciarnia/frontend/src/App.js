import './App.css';

import { useEffect, useState } from 'react';
import CartPage from './components/CartPage';
import HomePage from './components/HomePage';
import ProductDetailPage from './components/ProductDetailPage';
import SiteFooter from './components/SiteFooter';
import SiteHeader from './components/SiteHeader';
import { cartKey, products, readCart } from './data/products';

function App() {
  const [cart, setCart] = useState(readCart);
  const [search, setSearch] = useState('');
  const [category, setCategory] = useState('Wszystkie');
  const [notice, setNotice] = useState('');
  const [payment, setPayment] = useState('');
  const [customer, setCustomer] = useState({ firstName: '', lastName: '', street: '', house: '', city: '', postal: '', phone: '', email: '' });
  const [submitting, setSubmitting] = useState(false);
  const [orderComplete, setOrderComplete] = useState(false);

  const params = new URLSearchParams(window.location.search);
  const view = params.get('view');
  const selectedProduct = products.find((product) => product.id === params.get('id'));

  useEffect(() => {
    const syncCart = () => setCart(readCart());
    window.addEventListener('storage', syncCart);
    window.addEventListener('hortensja-cart-change', syncCart);
    return () => {
      window.removeEventListener('storage', syncCart);
      window.removeEventListener('hortensja-cart-change', syncCart);
    };
  }, []);

  const saveCart = (nextCart) => {
    setCart(nextCart);
    localStorage.setItem(cartKey, JSON.stringify(nextCart));
    window.dispatchEvent(new Event('hortensja-cart-change'));
  };

  const addToCart = (product, quantity = 1) => {
    const nextCart = { ...readCart(), [product.id]: (readCart()[product.id] || 0) + Number(quantity) };
    saveCart(nextCart);
    setNotice(`${product.name} dodano do koszyka.`);
    window.setTimeout(() => setNotice(''), 2800);
  };

  const changeQuantity = (id, value) => {
    const quantity = Math.max(0, Math.min(99, Number(value) || 0));
    const nextCart = { ...cart };
    if (quantity === 0) delete nextCart[id];
    else nextCart[id] = quantity;
    saveCart(nextCart);
  };

  const openWindow = (query) => {
    const popup = window.open(`${window.location.pathname}${query}`, '_blank', 'width=1100,height=850');
    if (!popup) setNotice('Przeglądarka zablokowała nowe okno. Zezwól na wyskakujące okna dla tej strony.');
  };

  const cartItems = products.filter((product) => cart[product.id] > 0);
  const itemCount = Object.values(cart).reduce((sum, quantity) => sum + Number(quantity || 0), 0);
  const total = cartItems.reduce((sum, product) => sum + product.price * cart[product.id], 0);
  const visibleProducts = products.filter((product) => {
    const matchesCategory = category === 'Wszystkie' || product.category === category;
    const matchesSearch = product.name.toLowerCase().includes(search.toLowerCase());
    return matchesCategory && matchesSearch;
  });

  const submitOrder = async (event) => {
    event.preventDefault();
    setNotice('');
    const fields = Object.values(customer).map((value) => value.trim());
    if (fields.some((value) => !value)) {
      setNotice('Proszę uzupełnić wszystkie dane osobowe i adresowe.');
      return;
    }
    if (!payment) {
      setNotice('Zamówienie nie jest opłacone. Proszę wybrać sposób płatności.');
      return;
    }
    if (cartItems.length === 0) {
      setNotice('Koszyk jest pusty. Dodaj kwiaty przed złożeniem zamówienia.');
      return;
    }

    setSubmitting(true);
    try {
      const response = await fetch('http://localhost:3100/api/orders', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ customer, payment, items: cartItems.map((product) => ({ id: product.id, name: product.name, price: product.price, quantity: cart[product.id] })), total }),
      });
      const result = await response.json();
      if (!response.ok) throw new Error(result.message || 'Nie udało się przyjąć zamówienia.');
      saveCart({});
      setOrderComplete(true);
    } catch (error) {
      setNotice(error.message === 'Failed to fetch' ? 'Nie można połączyć się z serwerem. Spróbuj ponownie za chwilę.' : error.message);
    } finally {
      setSubmitting(false);
    }
  };

  const header = (compact = false) => (
    <SiteHeader compact={compact} itemCount={itemCount} onOpenCart={() => openWindow('?view=cart')} showCart={view !== 'cart'} />
  );

  const footer = () => <SiteFooter />;

  if (view === 'product') {
    return <main className="page-shell popup-shell">{header(true)}<ProductDetailPage product={selectedProduct} onAddToCart={addToCart} onOpenCart={() => openWindow('?view=cart')} notice={notice} />{footer()}</main>;
  }

  if (view === 'cart') {
    return <main className="page-shell popup-shell">{header(true)}<CartPage cart={cart} cartItems={cartItems} customer={customer} itemCount={itemCount} notice={notice} onChangeQuantity={changeQuantity} onCustomerChange={(field, value) => setCustomer({ ...customer, [field]: value })} onPaymentChange={setPayment} onSubmitOrder={submitOrder} orderComplete={orderComplete} payment={payment} submitting={submitting} total={total} />{footer()}</main>;
  }

  return <main className="page-shell">{header()}<HomePage category={category} onAddToCart={addToCart} onOpenProduct={(productId) => openWindow(`?view=product&id=${productId}`)} onSearchChange={setSearch} onCategoryChange={setCategory} products={visibleProducts} search={search} />{footer()}{notice && <div className="toast" role="status">{notice}</div>}</main>;
}

export default App;
