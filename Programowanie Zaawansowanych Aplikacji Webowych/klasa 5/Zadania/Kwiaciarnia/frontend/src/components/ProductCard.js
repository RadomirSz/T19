import { money } from '../utils';

export default function ProductCard({ product, index }) {
  return <article className="product-card">
    <a className="product-image-button" href={`?view=product&id=${product.id}`} target="_blank" rel="noopener noreferrer" aria-label={`Informacje o produkcie ${product.name}`}>
      <img src={product.image} alt={product.name} loading={index > 2 ? 'lazy' : 'eager'} />
    </a>
    <div className="product-meta">
      <h3>{product.name}</h3>
      <p>{money(product.price)}</p>
    </div>
    <a className="info-button" href={`?view=product&id=${product.id}`} target="_blank" rel="noopener noreferrer">info o produkcie</a>
  </article>;
}