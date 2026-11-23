import ProductCard from './ProductCard';

export default function HomePage({ products, loading, error, onRetry }) {
  return <section className="shop-section" id="oferta">
    <h2 className="offer-title">Nasza oferta:</h2>
    {loading && <p role="status">Ładowanie kwiatów...</p>}
    {error && <div className="catalog-error"><p role="alert">{error}</p><button className="button button--primary" onClick={onRetry}>Spróbuj ponownie</button></div>}
    <div className="product-grid">
      {!loading && !error && products.map((product, index) => <ProductCard key={product.id} product={product} index={index} />)}
    </div>
    {!loading && !error && products.length === 0 && <p className="empty-message">Brak kwiatów w ofercie.</p>}
  </section>;
}