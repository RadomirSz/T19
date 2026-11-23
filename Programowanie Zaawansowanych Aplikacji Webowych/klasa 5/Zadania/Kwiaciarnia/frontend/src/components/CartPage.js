import { money } from '../utils';

const customerFields = [
  ['firstName', 'Imię', 30],
  ['lastName', 'Nazwisko', 30],
  ['street', 'Ulica', 30],
  ['house', 'Numer domu / lokalu', 10],
  ['city', 'Miejscowość', 60],
  ['postal', 'Kod pocztowy', 10],
  ['phone', 'Telefon', 20],
  ['email', 'Adres e-mail', 50],
];

export default function CartPage({ cart, cartItems, customer, itemCount, notice, loading, catalogError, onRetry, onChangeQuantity, onCustomerChange, onPaymentChange, onSubmitOrder, orderComplete, payment, submitting, total }) {
  if (orderComplete) {
    return <section className="order-success">
      <span className="success-mark">✓</span>
      <h1>Zamówienie zostało przyjęte do realizacji.</h1>
      <p>Proszę sprawdzić wiadomość na skrzynce pocztowej <strong>{customer.email}</strong>.</p>
      {notice && <p className="notice notice--error" role="alert">{notice}</p>}
      <a className="button button--primary" href="/">Wróć do kwiatów <span>↗</span></a>
    </section>;
  }

  if (loading || catalogError) return <section className="cart-page">
    <div className="section-heading"><h1>Zawartość koszyka:</h1></div>
    {loading && <p role="status">Ładowanie koszyka...</p>}
    {catalogError && <div className="catalog-error"><p role="alert">{catalogError}</p><button className="button button--primary" onClick={onRetry}>Spróbuj ponownie</button></div>}
  </section>;

  return <section className="cart-page">
    <div className="section-heading"><h1>Zawartość koszyka:</h1></div>
    {cartItems.length === 0 ? <div className="empty-cart">
      <p>Koszyk jest pusty.</p>
      <a className="button button--primary" href="/">Wróć do zakupów <span>↗</span></a>
    </div> : <div className="checkout-layout">
      <div className="cart-column">
        <div className="cart-list">
          {cartItems.map((product, index) => <article className="cart-row" key={product.id}>
            <span className="cart-index">0{index + 1}</span>
            <img src={product.image} alt="" />
            <div className="cart-product-info">
              <h2>{product.name}</h2>
              <p>{money(product.price)} / szt.</p>
              <button className="text-button" onClick={() => onChangeQuantity(product.id, 0)}>Usuń</button>
            </div>
            <label className="quantity-control">
              <span>Ilość</span>
              <input aria-label={`Ilość: ${product.name}`} type="number" min="1" max="99" value={cart[product.id]} onChange={(event) => onChangeQuantity(product.id, event.target.value)} />
            </label>
            <strong className="line-total">{money(product.price * cart[product.id])}</strong>
          </article>)}
        </div>
        <div className="cart-total"><span>Do zapłaty <small>({itemCount} produktów)</small></span><strong>{money(total)}</strong></div>
      </div>
      <form className="order-form" onSubmit={onSubmitOrder} noValidate>
        <h2>Informacje o realizacji zamówienia:</h2>
        <label className="form-label">Sposób płatności
          <select value={payment} onChange={(event) => onPaymentChange(event.target.value)}>
            <option value="">Wybierz płatność</option>
            <option value="Stripe">Stripe</option>
            <option value="przelew on line">przelew on line</option>
            <option value="PayPal">PayPal</option>
            <option value="Karta Kredytowa">Karta Kredytowa</option>
          </select>
        </label>
        <div className="form-grid">
          {customerFields.map(([key, label, maxLength]) => <label className="form-label" key={key}>{label}
            <input required maxLength={maxLength} type={key === 'email' ? 'email' : key === 'phone' ? 'tel' : 'text'} autoComplete={key === 'firstName' ? 'given-name' : key === 'lastName' ? 'family-name' : key === 'email' ? 'email' : 'off'} value={customer[key]} onChange={(event) => onCustomerChange(key, event.target.value)} />
          </label>)}
        </div>
        {notice && <p className="notice notice--error" role="alert">{notice}</p>}
        <button className="button button--primary submit-button" type="submit" disabled={submitting}>{submitting ? 'Wysyłanie…' : 'Wyślij zamówienie'} <span aria-hidden="true">↗</span></button>
      </form>
    </div>}
  </section>;
}