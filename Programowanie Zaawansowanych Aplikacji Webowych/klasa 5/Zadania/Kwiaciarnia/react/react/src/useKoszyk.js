 import { useEffect, useState } from 'react';

function useKoszyk() {
  const [koszyk, setKoszyk] = useState(() => {
    try {
      const dane = JSON.parse(localStorage.getItem('koszyk') || '[]');
      return Array.isArray(dane) ? dane : [];
    } catch {
      return [];
    }
  });

  useEffect(() => {
    const aktualizuj = () => {
      try {
        const dane = JSON.parse(localStorage.getItem('koszyk') || '[]');
        setKoszyk(Array.isArray(dane) ? dane : []);
      } catch {
        setKoszyk([]);
      }
    };
    window.addEventListener('storage', aktualizuj);
    window.addEventListener('focus', aktualizuj);
    window.addEventListener('zmiana-koszyka', aktualizuj);
    return () => {
      window.removeEventListener('storage', aktualizuj);
      window.removeEventListener('focus', aktualizuj);
      window.removeEventListener('zmiana-koszyka', aktualizuj);
    };
  }, []);

  const zapisz = (pozycje) => {
    localStorage.setItem('koszyk', JSON.stringify(pozycje));
    setKoszyk(pozycje);
    window.dispatchEvent(new Event('zmiana-koszyka'));
  };
  return { koszyk, zapisz };
}

export default useKoszyk;
