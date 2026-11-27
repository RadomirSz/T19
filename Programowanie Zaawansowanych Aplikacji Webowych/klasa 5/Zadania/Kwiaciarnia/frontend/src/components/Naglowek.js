import { useState } from 'react';
import { Link } from 'react-router-dom';

export default function SiteHeader({ compact, image }) {
  const [imageError, setImageError] = useState(false);

  return <header className={`site-header${compact ? ' site-header--compact' : ''}`}>
    <Link className="brand" to="/" aria-label="Hortensja, strona główna">
      {image && !imageError
        ? <img className="brand-mark" src={image} alt="" onError={() => setImageError(true)} />
        : <span className="brand-mark" aria-hidden="true">H</span>}
      <span className="brand-copy"><strong>Kwiaciarnia internetowa Hortensja<br />kwiaty dla Twoich bliskich,<br />gdziekolwiek są...</strong></span>
    </Link>
  </header>;
}