export default function SiteHeader({ compact, image }) {
  return <header className={`site-header${compact ? ' site-header--compact' : ''}`}>
    <a className="brand" href="/" aria-label="Hortensja, strona główna">
      {image ? <img className="brand-mark" src={image} alt="" /> : <span className="brand-mark" aria-hidden="true">H</span>}
      <span className="brand-copy"><strong>Kwiaciarnia internetowa Hortensja<br />kwiaty dla Twoich bliskich,<br />gdziekolwiek są...</strong></span>
    </a>
  </header>;
}