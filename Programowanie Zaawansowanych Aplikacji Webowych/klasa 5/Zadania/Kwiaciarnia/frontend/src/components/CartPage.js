import { money } from '../data/products';

const customerFields = [
  ['firstName', 'Imię'],
  ['lastName', 'Nazwisko'],
  ['street', 'Ulica'],
  ['house', 'Numer domu / lokalu'],
  ['city', 'Miejscowość'],
  ['postal', 'Kod pocztowy'],
  ['phone', 'Telefon'],
  ['email', 'Adres e-mail'],
];

export default function CartPage({ cart, cartItems, customer, itemCount, notice, onChangeQuantity, onCustomerChange, onPaymentChange, onSubmitOrder, orderComplete, payment, submitting, total }) {
  if (orderComplete) {
    return <section className="order-success">
      <span className="success-mark">✓</span>
      <p className="eyebrow">DZIĘKUJEMY</p>
      <h1>Zamówienie przyjęte<br />do realizacji.</h1>
      <p>Potwierdzenie wysłaliśmy na adres <strong>{customer.email}</strong>.</p>
      <a className="button button--primary" href="/">Wróć do kwiatów <span>↗</span></a>
    </section>;
  }

  return <section className="cart-page">
    <div className="section-heading"><p className="eyebrow">TWÓJ WYBÓR</p><h1>Zawartość koszyka<span>.</span></h1></div>
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
        <p className="eyebrow">DOSTAWA I PŁATNOŚĆ</p>
        <h2>Dokąd wysłać<br />trochę radości?</h2>
        <label className="form-label">Sposób płatności
          <select value={payment} onChange={(event) => onPaymentChange(event.target.value)}>
            <option value="">Wybierz płatność</option>
            <option value="BLIK">BLIK</option>
            <option value="Karta płatnicza">Karta płatnicza</option>
            <option value="Przelew online">Przelew online</option>
            <option value="Przy odbiorze">Przy odbiorze</option>
          </select>
        </label>
        <div className="form-grid">
          {customerFields.map(([key, label]) => <label className="form-label" key={key}>{label}
            <input required type={key === 'email' ? 'email' : key === 'phone' ? 'tel' : 'text'} autoComplete={key === 'firstName' ? 'given-name' : key === 'lastName' ? 'family-name' : key === 'email' ? 'email' : 'off'} value={customer[key]} onChange={(event) => onCustomerChange(key, event.target.value)} />
          </label>)}
        </div>
        {notice && <p className="notice notice--error" role="alert">{notice}</p>}
        <button className="button button--primary submit-button" type="submit" disabled={submitting}>{submitting ? 'Wysyłanie…' : 'Wyślij zamówienie'} <span aria-hidden="true">↗</span></button>
        <p className="privacy-note">Dane wykorzystamy wyłącznie do realizacji zamówienia.</p>
      </form>
    </div>}
  </section>;
}