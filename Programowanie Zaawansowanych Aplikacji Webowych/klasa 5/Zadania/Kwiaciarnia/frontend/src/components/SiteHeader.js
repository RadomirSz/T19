export default function SiteHeader({ compact, itemCount, onOpenCart, showCart }) {
  return <header className={`site-header${compact ? ' site-header--compact' : ''}`}>
    <a className="brand" href="/" aria-label="Hortensja, strona główna">
      <span className="brand-mark" aria-hidden="true">h.</span>
      <span className="brand-copy"><strong>hortensja</strong><small>kwiaty z dobrego miejsca</small></span>
    </a>
    <div className="header-note">Kwiaty, które mówią za Ciebie <span>✳</span></div>
    {showCart && <button className="cart-link" onClick={onOpenCart}><span aria-hidden="true">♧</span> Koszyk <b>{itemCount}</b></button>}
  </header>;
}