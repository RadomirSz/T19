export const products = [
  { id: 'peonie', name: 'Peonie koralowe', category: 'Bukiety', price: 89, detail: 'Pachnące peonie w odcieniach malin i koralu.', image: 'https://images.unsplash.com/photo-1490750967868-88aa4486c946?auto=format&fit=crop&w=1000&q=85', tag: 'Bestseller' },
  { id: 'tulipany', name: 'Tulipany o poranku', category: 'Bukiety', price: 64, detail: 'Sezonowe tulipany, które rozjaśnią każdy dzień.', image: 'https://images.unsplash.com/photo-1520763185298-1b434c919102?auto=format&fit=crop&w=1000&q=85', tag: 'Sezonowe' },
  { id: 'polne', name: 'Łąka w wazonie', category: 'Bukiety', price: 76, detail: 'Luźna kompozycja inspirowana letnią łąką.', image: 'https://images.unsplash.com/photo-1494972308805-463bc619d34e?auto=format&fit=crop&w=1000&q=85', tag: 'Naturalne' },
  { id: 'roze', name: 'Róże i eukaliptus', category: 'Bukiety', price: 119, detail: 'Klasyczne róże z pachnącą zielenią.', image: 'https://images.unsplash.com/photo-1518895949257-7621c3c786d7?auto=format&fit=crop&w=1000&q=85', tag: 'Klasyka' },
  { id: 'donica', name: 'Fiołek afrykański', category: 'Rośliny', price: 42, detail: 'Wdzięczna roślina doniczkowa, gotowa na parapet.', image: 'https://images.unsplash.com/photo-1497250681960-ef046c08a56e?auto=format&fit=crop&w=1000&q=85', tag: 'Na lata' },
  { id: 'lilie', name: 'Lilie w kremie', category: 'Bukiety', price: 98, detail: 'Eleganckie lilie i subtelne dodatki.', image: 'https://images.unsplash.com/photo-1508610048659-a06b669e3321?auto=format&fit=crop&w=1000&q=85', tag: 'Eleganckie' },
];

export const cartKey = 'hortensja-cart';
export const money = (amount) => `${Number(amount).toFixed(2).replace('.', ',')} zł`;

export function readCart() {
  try {
    return JSON.parse(localStorage.getItem(cartKey) || '{}');
  } catch {
    return {};
  }
}