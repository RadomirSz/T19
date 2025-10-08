# Salon Samochodowy - Wataha Trans

## Opis projektu

Strona internetowa salonu samochodowego "Wataha Trans" oferującego samochody nowe i używane. Projekt wykonany zgodnie z wymaganiami zadania.

## Funkcjonalności

### ✅ Realizacja wymagań zadania:

1. **Nazwa karty**: "Salon samochodowy"
2. **Nagłówek strony zawiera**:
   - Napis "Witamy na stronie firmy: Wataha Trans"
   - Konfigurowalna nazwa firmy (zmienna `companyInfo.name` w pliku `data.js`)
   - Logo firmy (plik SVG)
3. **Oferta salonu**: Wyświetlana w postaci kart z pojazdami
4. **Stopka**: "Zapraszamy codziennie od otwarcia do zamknięcia"
5. **Formatowanie**: Responsywny design z nowoczesnymi stylami CSS
6. **Struktura katalogów**: Zorganizowana struktura React z komponentami

### 🚗 Oferta samochodów:

- Volkswagen Kafer (1970) - 25,000 PLN
- Ford Mustang (2020) - 120,000 PLN
- BMW E30 (1985) - 35,000 PLN
- Mercedes W123 (1980) - 28,000 PLN
- Porsche 911 (2019) - 450,000 PLN
- Audi Quattro (1984) - 55,000 PLN

## Struktura projektu

```
src/
├── App.js          # Główny komponent aplikacji
├── App.css         # Style głównej aplikacji
├── Header.js       # Komponent nagłówka
├── CarCard.js      # Komponent karty samochodu
├── Footer.js       # Komponent stopki
├── data.js         # Dane samochodów i informacje o firmie
├── index.js        # Punkt wejścia aplikacji
├── index.css       # Globalne style
└── reportWebVitals.js

public/
├── index.html                # Główny plik HTML
├── logo-wataha-trans.svg     # Logo firmy
└── manifest.json            # Manifest aplikacji
```

## Technologie

- **React 19.1.1** - Biblioteka do budowania interfejsów użytkownika
- **CSS3** - Stylowanie z flexbox i grid
- **SVG** - Logo firmy w formacie wektorowym
- **Responsive Design** - Adaptacja do różnych rozmiarów ekranu

## Uruchamianie

```bash
npm start
```

Aplikacja będzie dostępna pod adresem: http://localhost:3000

## Funkcje dodatkowe

- **Responsywny design** - strona dostosowuje się do różnych urządzeń
- **Hover effects** - interaktywne animacje przy najechaniu na karty
- **Modułowa struktura** - kod podzielony na komponenty
- **Konfigurowalne dane** - łatwa zmiana informacji o firmie i samochodach

## Autor

Projekt wykonany zgodnie z wymaganiami zadania dla klasy 4, przedmiot: Programowanie Zaawansowanych Aplikacji Webowych.