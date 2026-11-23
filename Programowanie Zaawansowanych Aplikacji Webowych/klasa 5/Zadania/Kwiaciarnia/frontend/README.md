# Kwiaciarnia Hortensja

## Uruchomienie

Polecenia poniżej uruchamiaj z katalogu `Kwiaciarnia`.

1. W MySQL utwórz bazę `kwiaciarnia` i zaimportuj do niej `bazaZadanie.sql` z folderu nadrzędnego.
2. W terminalu uruchom backend:

   ```powershell
   cd Backend
   npm install
   npm start
   ```

3. W drugim terminalu uruchom frontend:

   ```powershell
   cd frontend
   npm install
   npm start
   ```

Backend domyślnie łączy się z MySQL na `localhost:3306` (użytkownik `root`, puste hasło, baza `kwiaciarnia`). Jeśli Twoja konfiguracja MySQL używa innego hasła lub użytkownika, ustaw zmienne w terminalu przed uruchomieniem backendu:

```powershell
$env:DB_HOST = "localhost"
$env:DB_PORT = "3306"
$env:DB_USER = "root"
$env:DB_PASSWORD = "twoje_haslo_mysql"
$env:DB_NAME = "kwiaciarnia"
npm start
```

Wartości można też ustawić zgodnie z konfiguracją MySQL na Twoim komputerze.
