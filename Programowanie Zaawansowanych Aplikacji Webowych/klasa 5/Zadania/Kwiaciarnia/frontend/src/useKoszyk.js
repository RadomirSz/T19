import { useEffect, useState } from 'react';
import { cartKey, readCart } from './narzedzia';

export default function useKoszyk() {
  const [koszyk, setKoszyk] = useState(readCart);

  useEffect(() => {
    const aktualizuj = () => setKoszyk(readCart());
    window.addEventListener('storage', aktualizuj);
    window.addEventListener('hortensja-cart-change', aktualizuj);
    return () => {
      window.removeEventListener('storage', aktualizuj);
      window.removeEventListener('hortensja-cart-change', aktualizuj);
    };
  }, []);

  const zapisz = (nowyKoszyk) => {
    try {
      localStorage.setItem(cartKey, JSON.stringify(nowyKoszyk));
      setKoszyk(nowyKoszyk);
      window.dispatchEvent(new Event('hortensja-cart-change'));
      return true;
    } catch {
      return false;
    }
  };

  return { koszyk, zapisz };
}
