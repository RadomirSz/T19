export const calculateQuadraticEquation = (a, b, c) => {
  const aNum = parseFloat(a);
  const bNum = parseFloat(b);
  const cNum = parseFloat(c);

  // Walidacja
  if (isNaN(aNum) || isNaN(bNum) || isNaN(cNum)) {
    return { error: 'Wszystkie wartości muszą być liczbami' };
  }

  if (aNum === 0) {
    return { error: 'Współczynnik a nie może być równy 0' };
  }

  // Obliczenia
  const delta = bNum * bNum - 4 * aNum * cNum;
  const x1 = delta >= 0 ? (-bNum - Math.sqrt(delta)) / (2 * aNum) : null;
  const x2 = delta >= 0 ? (-bNum + Math.sqrt(delta)) / (2 * aNum) : null;

  return {
    a: aNum,
    b: bNum,
    c: cNum,
    delta,
    x1,
    x2
  };
};
