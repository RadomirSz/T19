@echo off
echo ========================================
echo   URUCHAMIANIE SERWERA API REZERWACJI
echo ========================================
echo.
echo UWAGA: Uruchom ten plik jako ADMINISTRATOR!
echo.
pause

cd /d "%~dp0"

echo Przywracanie pakietow NuGet...
dotnet restore

if errorlevel 1 (
    echo.
    echo BLAD: Nie udalo sie przywrocic pakietow!
    pause
    exit /b 1
)

echo.
echo Budowanie projektu...
dotnet build

if errorlevel 1 (
    echo.
    echo BLAD: Nie udalo sie zbudowac projektu!
    pause
    exit /b 1
)

echo.
echo Uruchamianie serwera...
echo.
dotnet run

pause
