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
