const http = require('http');
const { randomUUID } = require('crypto');

const PORT = Number(process.env.PORT || 3100);
const orders = [];
const catalog = {
  peonie: { name: 'Peonie koralowe', price: 89 },
  tulipany: { name: 'Tulipany o poranku', price: 64 },
  polne: { name: 'Łąka w wazonie', price: 76 },
  roze: { name: 'Róże i eukaliptus', price: 119 },
  donica: { name: 'Fiołek afrykański', price: 42 },
  lilie: { name: 'Lilie w kremie', price: 98 },
};
const requiredFields = ['firstName', 'lastName', 'street', 'house', 'city', 'postal', 'phone', 'email'];
const paymentMethods = ['BLIK', 'Karta płatnicza', 'Przelew online', 'Przy odbiorze'];

function send(response, status, payload) {
  response.writeHead(status, { 'Content-Type': 'application/json; charset=utf-8' });
  response.end(JSON.stringify(payload));
}

const server = http.createServer(async (request, response) => {
  const origin = request.headers.origin || '';
  if (/^http:\/\/(localhost|127\.0\.0\.1):3000$/.test(origin)) {
    response.setHeader('Access-Control-Allow-Origin', origin);
    response.setHeader('Vary', 'Origin');
  }
  response.setHeader('Access-Control-Allow-Methods', 'GET, POST, OPTIONS');
  response.setHeader('Access-Control-Allow-Headers', 'Content-Type');

  if (request.method === 'OPTIONS') {
    response.writeHead(204);
    response.end();
    return;
  }
  if (request.method === 'GET' && request.url === '/api/health') {
    send(response, 200, { status: 'ok' });
    return;
  }
  if (request.method !== 'POST' || request.url !== '/api/orders') {
    send(response, 404, { message: 'Nie znaleziono tego adresu.' });
    return;
  }

  let body = '';
  try {
    for await (const chunk of request) {
      body += chunk;
      if (body.length > 1_000_000) {
        send(response, 413, { message: 'Zamówienie jest zbyt duże.' });
        return;
      }
    }
    const data = JSON.parse(body);
    const { customer, payment, items } = data;

    if (!customer || requiredFields.some((field) => typeof customer[field] !== 'string' || !customer[field].trim())) {
      send(response, 400, { message: 'Proszę uzupełnić wszystkie dane do wysyłki.' });
      return;
    }
    if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(customer.email)) {
      send(response, 400, { message: 'Podaj prawidłowy adres e-mail.' });
      return;
    }
    if (!paymentMethods.includes(payment) || !Array.isArray(items) || items.length === 0) {
      send(response, 400, { message: 'Wybierz płatność i dodaj produkty do koszyka.' });
      return;
    }

    const acceptedItems = [];
    for (const item of items) {
      const product = catalog[item.id];
      const quantity = Number(item.quantity);
      if (!product || !Number.isInteger(quantity) || quantity < 1 || quantity > 99) {
        send(response, 400, { message: 'Zamówienie zawiera nieprawidłowy produkt lub ilość.' });
        return;
      }
      acceptedItems.push({ id: item.id, name: product.name, price: product.price, quantity });
    }

    const total = acceptedItems.reduce((sum, item) => sum + item.price * item.quantity, 0);
    const order = { id: randomUUID(), customer, payment, items: acceptedItems, total, createdAt: new Date().toISOString() };
    orders.push(order);
    console.log(`Order ${order.id} accepted: ${total.toFixed(2)} PLN`);
    send(response, 201, { message: 'Zamówienie zostało przyjęte do realizacji.', orderId: order.id, total });
  } catch {
    send(response, 400, { message: 'Nieprawidłowe dane zamówienia.' });
  }
});

server.listen(PORT, () => {
  console.log(`Server is running on http://localhost:${PORT}`);
});
