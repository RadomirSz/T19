export const API_URL = process.env.REACT_APP_API_URL || 'http://localhost:3100';
export const cartKey = 'hortensja-cart';

export function money(value) {
  return `${Number(value).toFixed(2)} zł`;
}

export function readCart() {
  try {
    const cart = JSON.parse(localStorage.getItem(cartKey) || '{}');
    if (!cart || Array.isArray(cart) || typeof cart !== 'object') return {};
    return Object.fromEntries(
      Object.entries(cart).filter(([, quantity]) => Number.isInteger(quantity) && quantity > 0)
    );
  } catch {
    return {};
  }
}

export async function fetchFlowers() {
  const response = await fetch(`${API_URL}/api/flowers`);
  const data = await response.json();
  if (!response.ok) throw new Error(data.error || 'Nie udało się pobrać kwiatów.');
  if (!Array.isArray(data)) throw new Error('Serwer zwrócił nieprawidłowe dane.');

  return data.map((flower) => {
    const id = Number(flower.IDkwiat);
    const price = Number(flower.cena);
    if (!Number.isSafeInteger(id) || !Number.isFinite(price)) return null;

    return {
      id,
      name: String(flower.nazwa || '').trim(),
      price,
      detail: String(flower.notatka || '').trim(),
      image: `${API_URL}/api/images/${id}/kwiat.jpg`,
    };
  }).filter(Boolean);
}
