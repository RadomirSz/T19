export default function SiteFooter({ image }) {
  return <footer className={`site-footer${image ? '' : ' site-footer--empty'}`}>
    {image && <img src={image} alt="Kwiaty z naszej oferty" />}
    <div><p>Dziś imieniny mają:</p><p>Anna, Andrzej, Barbara, Bogdan.</p><p>Ale kwiaty możesz przesłać każdemu :)</p></div>
  </footer>;
}