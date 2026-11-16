# Księgarnia

## Uruchomienie

1. W XAMPP uruchom MySQL i zaimportuj `backend/ksiegarniaBD.sql` do bazy `ksiegarnia`.
2. W katalogu `backend` wykonaj `npm install`, potem `npm start`.
3. W drugim terminalu, w katalogu `frontend`, wykonaj `npm install`, potem `npm start`.
4. Otwórz `http://localhost:3000`.

Backend łączy się domyślnie z `localhost:3306` jako `root` bez hasła. W razie potrzeby ustaw `DB_HOST`, `DB_PORT`, `DB_USER`, `DB_PASSWORD` lub `DB_NAME`.

Autorzy dodani formularzem są dopisywani tylko do listy w przeglądarce. Nie są zapisywani w bazie i znikają po odświeżeniu strony.

## Gdzie zmieniać ustawienia i dane

- Nazwa księgarni i tekst stopki: stałe `BOOKSTORE_NAME` i `OPENING_MESSAGE` w `src/App.js`.
- Zapytania do bazy i API: `backend/index.js`.
- Struktura i przykładowe dane bazy: `backend/ksiegarniaBD.sql`.
- Okładki: `backend/grafika/<ID książki>/okladka.jpg`.

## Podział frontendu

```text
src/
  App.js                 składa nagłówek, treść i stopkę
  App.css                style strony
  index.css              style całego dokumentu
  index.js               uruchomienie Reacta
  components/
    Header.js            nagłówek i konfigurowalna nazwa księgarni
    Main.js              oferta, wyszukiwanie i formularze
    Footer.js            stopka z konfigurowanym tekstem
```

## Struktura projektu

```text
backend/
  grafika/             okładki z nazwami katalogów równymi ID książek
  index.js             API i połączenie z MySQL
  ksiegarniaBD.sql     tabele i przykładowe dane
  package.json         zależności backendu
frontend/
  public/index.html    dokument strony
  src/
    App.js             oferta, wyszukiwanie i formularze
    App.css            proste style strony
    index.css          podstawowe style dokumentu
    index.js           uruchomienie aplikacji React
```
