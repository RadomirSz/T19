import { money } from '../data/products';

export default function ProductCard({ product, index, onAddToCart, onOpenProduct }) {
  return <article className="product-card">
    <button className="product-image-button" onClick={() => onOpenProduct(product.id)} aria-label={`Informacje o produkcie ${product.name}`}>
      <img src={product.image} alt={product.name} loading={index > 2 ? 'lazy' : 'eager'} />
      <span className="product-tag">{product.tag}</span>
      <span className="image-arrow" aria-hidden="true">↗</span>
    </button>
    <div className="product-meta">
      <div><p className="product-category">{product.category}</p><h3>{product.name}</h3></div>
      <strong>{money(product.price)}</strong>
    </div>
    <div className="product-actions">
      <button className="info-button" onClick={() => onOpenProduct(product.id)}>Info o produkcie <span>↗</span></button>
      <button className="add-button" onClick={() => onAddToCart(product)} aria-label={`Dodaj ${product.name} do koszyka`}>Dodaj do koszyka <span>＋</span></button>
    </div>
  </article>;
}