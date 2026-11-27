import { money } from '../narzedzia';
import { Link } from 'react-router-dom';

export default function ProductCard({ product, index }) {
  return <article className="product-card">
    <Link className="product-image-button" to={`/kwiat/${product.id}`} target="_blank" rel="noopener noreferrer" aria-label={`Informacje o produkcie ${product.name}`}>
      <img src={product.image} alt={product.name} loading={index > 2 ? 'lazy' : 'eager'} />
    </Link>
    <div className="product-meta">
      <h3>{product.name}</h3>
      <p>{money(product.price)}</p>
    </div>
    <Link className="info-button" to={`/kwiat/${product.id}`} target="_blank" rel="noopener noreferrer">info o produkcie</Link>
  </article>;
}