# ?? System Rezerwacji ¯aglówek - Instrukcja Uruchomienia

## ?? Struktura Projektu

```
Projekt-POB/
??? System Rezerwacji ¯aglówek Online/  # Aplikacja kliencka (Console)
?   ??? Services/
?       ??? ReservationApiService.cs
??? ReservationApiServer/            # Serwer API
    ??? Program.cs
    ??? Start-Server.bat
    ??? README.md
```

## ?? Jak Uruchomiæ System

### Krok 1: Uruchom Serwer API

**WA¯NE: Serwer musi byæ uruchomiony JAKO ADMINISTRATOR!**

#### Opcja A: U¿yj pliku batch
1. PrzejdŸ do folderu `ReservationApiServer`
2. Kliknij prawym na `Start-Server.bat`
3. Wybierz **"Uruchom jako administrator"**

#### Opcja B: Visual Studio
1. Otwórz Visual Studio **jako Administrator**
2. Ustaw `ReservationApiServer` jako Startup Project
3. Naciœnij F5 lub Ctrl+F5

#### Opcja C: Wiersz poleceñ (PowerShell jako Admin)
```powershell
cd ReservationApiServer
dotnet restore
dotnet build
dotnet run
```

**Serwer bêdzie dzia³a³ na:** `http://localhost:8080/`

### Krok 2: Uruchom Aplikacjê Klienck¹

Po uruchomieniu serwera:

1. W Visual Studio ustaw `System Rezerwacji ¯aglówek Online` jako Startup Project
2. Naciœnij F5 lub Ctrl+F5
3. Lub uruchom bezpoœrednio exe z folderu `bin\Debug`

## ? Test Po³¹czenia

1. Zaloguj siê lub zarejestruj u¿ytkownika w aplikacji klienckiej
2. Utwórz rezerwacjê (opcja 3 w menu)
3. Po utworzeniu rezerwacji system automatycznie wyœle j¹ do serwera
4. SprawdŸ logi w oknie serwera - powinna pojawiæ siê informacja o dodanej rezerwacji

### Oczekiwany wynik:

**W oknie serwera:**
```
? Dodano rezerwacjê (³¹cznie: 1)
```

**W aplikacji klienckiej:**
```
Rezerwacja wys³ana do serwera pomyœlnie!
```

## ?? Rozwi¹zywanie Problemów

### Problem: "Access is denied" przy uruchamianiu serwera
**Rozwi¹zanie:** Uruchom serwer jako Administrator

### Problem: "Nie uda³o siê wys³aæ rezerwacji do serwera"
**Rozwi¹zanie:** 
1. SprawdŸ czy serwer jest uruchomiony
2. SprawdŸ logi w konsoli serwera
3. SprawdŸ firewall Windows

### Problem: Port 8080 zajêty
**Rozwi¹zanie:** 
1. Zamknij aplikacjê u¿ywaj¹c¹ port 8080, LUB
2. Zmieñ port w:
   - `ReservationApiServer/Program.cs` (linia: `string url = "http://localhost:8080/"`)
   - `System Rezerwacji ¯aglówek Online/Services/ReservationApiService.cs` (linia: `API_URL`)

## ?? Cechy Systemu

### Aplikacja Kliencka:
- ? Rejestracja i logowanie u¿ytkowników
- ? Tworzenie rezerwacji ¿aglówek
- ? Przegl¹danie rezerwacji
- ? Automatyczne wysy³anie rezerwacji do serwera
- ? Logowanie wszystkich operacji

### Serwer API:
- ? RESTful API
- ? Przyjmowanie rezerwacji (POST)
- ? Zwracanie listy rezerwacji (GET)
- ? Logowanie operacji w czasie rzeczywistym
- ? Obs³uga CORS

## ?? Endpointy API

| Metoda | Endpoint | Opis |
|--------|----------|------|
| POST | `/api/reservations` | Dodaj now¹ rezerwacjê |
| GET | `/api/reservations` | Pobierz wszystkie rezerwacje |

## ?? Uwagi

- **Serwer przechowuje dane w pamiêci** - po zamkniêciu wszystkie rezerwacje zostan¹ utracone
- **Dla œrodowiska produkcyjnego** zalecane jest u¿ycie prawdziwej bazy danych
- **Uruchom serwer PRZED klientem** aby unikn¹æ b³êdów po³¹czenia

## ?? Bezpieczeñstwo

W obecnej wersji:
- Brak uwierzytelniania
- Brak szyfrowania (HTTP zamiast HTTPS)
- Brak walidacji danych wejœciowych

**To jest wersja edukacyjna/demonstracyjna. Dla produkcji nale¿y dodaæ odpowiednie zabezpieczenia!**

## ?? U¿yte Technologie

- .NET Framework 4.8
- C# 7.3
- HttpClient (klient)
- HttpListener (serwer)
- Newtonsoft.Json
- Design Patterns: Singleton, Factory, Builder

---

**Powodzenia! ??**
