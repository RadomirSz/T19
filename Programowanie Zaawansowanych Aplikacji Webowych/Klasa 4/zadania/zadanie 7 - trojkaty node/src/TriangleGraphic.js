export default function TriangleGraphic({ result }) {
  if (!result || !result.canBuild || !result.kind) return null;

  const opisRodzaju = result.kind.toLowerCase();
  let nazwaObrazka = 'dowolny';

  if (opisRodzaju.includes('rownoboczny')) {
    nazwaObrazka = 'rownoboczny';
  } else if (opisRodzaju.includes('prostokatny')) {
    nazwaObrazka = 'prostokatny';
  } else if (opisRodzaju.includes('rozwartokatny')) {
    nazwaObrazka = 'rozwartokatny';
  } else if (opisRodzaju.includes('ostrokatny')) {
    nazwaObrazka = 'ostrokatny';
  } else if (opisRodzaju.includes('rownoramienny')) {
    nazwaObrazka = 'rownoramienny';
  }

  return (
    <img
      className="triangle-image"
      src={`/${nazwaObrazka}.png`}
      alt={`Trojkat ${result.kind || ""}`}
      loading="lazy"
    />
  );
}
