import LinkNowaKarta from './LinkNowaKarta';

function KartaKwiata({ kwiat }) {
  return (
    <article className="karta-kwiata">
      <img
        src={`http://localhost:3100/api/images/${kwiat.IDkwiat}/kwiat.jpg`}
        alt={kwiat.nazwa}
      />
      <div className="karta-kwiata-tresc">
        <h2>{kwiat.nazwa}</h2>
        <p>{Number(kwiat.cena).toFixed(2)} zł</p>
        <LinkNowaKarta className="przycisk-info" to={`/kwiat/${kwiat.IDkwiat}`}>
          info o produkcie
        </LinkNowaKarta>
      </div>
    </article>
  );
}

export default KartaKwiata;



