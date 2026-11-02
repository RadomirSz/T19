import { money } from '../data/products';

export default function ProductDetailPage({ product, onAddToCart, onOpenCart, notice }) {
  if (!product) return <p className="empty-message">Nie znaleźliśmy tego produktu.</p>;

  return <section className="product-detail">
    <div className="detail-image-wrap"><img className="detail-image" src={product.image} alt={product.name} /></div>
    <div className="detail-copy">
      <p className="eyebrow">WYBRANY KWIAT · {product.category.toUpperCase()}</p>
      <h1>{product.name}</h1>
      <p className="detail-description">{product.detail} Każdy bukiet układamy ręcznie w naszej pracowni, z kwiatów wybranych tego samego dnia.</p>
      <p className="detail-price">{money(product.price)}</p>
      <div className="detail-actions">
        <button className="button button--primary" onClick={() => onAddToCart(product)}>Dodaj do koszyka <span aria-hidden="true">＋</span></button>
        <button className="button button--quiet" onClick={onOpenCart}>Przejdź do koszyka ↗</button>
      </div>
      {notice && <p className="notice notice--success" role="status">{notice}</p>}
    </div>
    <div className="product-note"><span>01 / 06</span><p>Informacja o kwiecie</p><small>{product.detail}</small></div>
  </section>;
}