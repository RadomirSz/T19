import ProductCard from './ProductCard';

const categories = ['Wszystkie', 'Bukiety', 'Rośliny'];

export default function HomePage({ category, onAddToCart, onOpenProduct, onSearchChange, onCategoryChange, products, search }) {
  return <>
    <section className="hero">
      <div className="hero-copy">
        <p className="eyebrow">KWIACIARNIA INTERNETOWA · WARSZAWA</p>
        <h1>Niech ten dzień<br />zakwitnie<span>.</span></h1>
        <p>Ręcznie układane bukiety, które mówią<br className="desktop-break" /> „pamiętam”, „dziękuję” i „jestem blisko”.</p>
        <a className="button button--dark" href="#oferta">Odkryj naszą ofertę <span>↓</span></a>
        <div className="hero-footnote"><span>01 — 06</span><span>Kwiaty na dobre chwile</span></div>
      </div>
      <div className="hero-image">
        <img src="https://images.unsplash.com/photo-1523438885200-e635ba2c371e?auto=format&fit=crop&w=1500&q=90" alt="Bukiet świeżych kwiatów w ciepłym świetle" />
        <span className="image-caption">Zebrane dziś. Ułożone z sercem.</span>
        <span className="hero-stamp">KWIATY<br />NA CO<br />DZIEŃ</span>
      </div>
    </section>
    <section className="shop-section" id="oferta">
      <div className="shop-heading">
        <div><p className="eyebrow">NASZA PRACOWNIA</p><h2>Wybierz coś<br />pięknego<span>.</span></h2></div>
        <div className="shop-controls">
          <div className="category-tabs" role="group" aria-label="Filtruj kategorię">
            {categories.map((option) => <button key={option} className={category === option ? 'is-active' : ''} onClick={() => onCategoryChange(option)}>{option}</button>)}
          </div>
          <label className="search-box"><span aria-hidden="true">⌕</span><input value={search} onChange={(event) => onSearchChange(event.target.value)} placeholder="Szukaj kwiatów" aria-label="Szukaj kwiatów" /></label>
        </div>
      </div>
      <div className="product-grid">
        {products.map((product, index) => <ProductCard key={product.id} product={product} index={index} onAddToCart={onAddToCart} onOpenProduct={onOpenProduct} />)}
      </div>
      {products.length === 0 && <p className="empty-message">Nie znaleźliśmy kwiatów pasujących do wyszukiwania.</p>}
    </section>
    <section className="promise-band">
      <span className="promise-symbol" aria-hidden="true">✳</span>
      <p>Świeże kwiaty. <em>Dobry gest.</em><br />Dostawa, która zdąży na czas.</p>
      <span className="promise-detail">Zamów do 13:00<br />wyślemy jeszcze dziś ↗</span>
    </section>
  </>;
}