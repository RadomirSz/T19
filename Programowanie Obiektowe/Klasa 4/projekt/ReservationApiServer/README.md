# ?? Serwer API Rezerwacji ¯aglówek

Prosty serwer HTTP API dla systemu rezerwacji ¿aglówek.

## ?? Wymagania

- .NET Framework 4.8
- Uprawnienia administratora (do nas³uchiwania na porcie HTTP)
- Newtonsoft.Json (automatycznie instalowany przez NuGet)

## ?? Jak uruchomiæ

### Sposób 1: Z Visual Studio

1. **Otwórz projekt w Visual Studio**
   - Kliknij prawym na rozwi¹zanie ? Add ? Existing Project
   - Wybierz `ReservationApiServer\ReservationApiServer.csproj`

2. **Uruchom jako Administrator**
- Kliknij prawym na projekt `ReservationApiServer` ? Set as Startup Project
   - Zamknij Visual Studio
   - Uruchom Visual Studio jako Administrator (prawy klik ? Run as Administrator)
   - Naciœnij F5 lub Ctrl+F5

### Sposób 2: Z wiersza poleceñ (jako Administrator)

```powershell
cd ReservationApiServer
dotnet restore
dotnet build
dotnet run
```

## ?? Endpointy API

Serwer dzia³a na: `http://localhost:8080/`

### POST /api/reservations
Dodaje now¹ rezerwacjê do systemu.

**Przyk³ad:**
```bash
POST http://localhost:8080/api/reservations
Content-Type: application/json

{
  "ReservationId": "ABC12345",
  "User": {...},
  "Yacht": {...},
  ...
}
```

### GET /api/reservations
Pobiera wszystkie rezerwacje z systemu.

**Przyk³ad:**
```bash
GET http://localhost:8080/api/reservations
```

## ?? Konfiguracja

Aby zmieniæ port, edytuj liniê w `Program.cs`:
```csharp
string url = "http://localhost:8080/";
```

Pamiêtaj, aby równie¿ zaktualizowaæ URL w kliencie:
`System Rezerwacji ¯aglówek Online\Services\ReservationApiService.cs`

## ?? Rozwi¹zywanie problemów

### B³¹d: "Access is denied"
**Rozwi¹zanie:** Uruchom aplikacjê jako Administrator

### B³¹d: "The process cannot access the file because it is being used"
**Rozwi¹zanie:** Port 8080 jest zajêty. Zmieñ port w konfiguracji lub zamknij aplikacjê u¿ywaj¹c¹ tego portu.

### Serwer nie odpowiada
1. SprawdŸ czy serwer jest uruchomiony
2. SprawdŸ firewall Windows
3. SprawdŸ czy URL w kliencie zgadza siê z URL serwera

## ?? Notatki

- Serwer przechowuje dane w pamiêci RAM - po restarcie wszystkie rezerwacje zostan¹ utracone
- Dla produkcji zalecane jest u¿ycie prawdziwej bazy danych
- Serwer obs³uguje CORS dla wszystkich origins (*)
