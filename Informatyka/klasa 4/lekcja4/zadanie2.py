def wczytaj_macierz(nazwa_pliku):
    macierz = []
    with open(nazwa_pliku, 'r') as plik:
        for linia in plik:
            wiersz = [int(x) for x in linia.strip().split()]
            macierz.append(wiersz)
    return macierz

def znajdz_maksymalna_sciezke(macierz):
    wiersze = len(macierz)
    kolumny = len(macierz[0])

    suma = macierz[0][0]  # Zaczynamy od lewego górnego rogu
    sciezka = ""
    wiersz, kolumna = 0, 0

    while wiersz < wiersze-1 or kolumna < kolumny-1:
        # Jesteśmy na ostatnim wierszu, możemy iść tylko w prawo
        if wiersz == wiersze-1:
            kolumna += 1
            suma += macierz[wiersz][kolumna]
            sciezka += "P"
            continue

        # Jesteśmy w ostatniej kolumnie, możemy iść tylko w dół
        if kolumna == kolumny-1:
            wiersz += 1
            suma += macierz[wiersz][kolumna]
            sciezka += "D"
            continue

        # Możemy iść w prawo lub w dół - wybieramy większą wartość
        prawo = macierz[wiersz][kolumna+1]
        dol = macierz[wiersz+1][kolumna]

        # Jeśli wartości są równe, idziemy w dół
        if dol >= prawo:
            wiersz += 1
            suma += macierz[wiersz][kolumna]
            sciezka += "D"
        else:
            kolumna += 1
            suma += macierz[wiersz][kolumna]
            sciezka += "P"

    return suma, sciezka

def main():
    try:
        macierz = wczytaj_macierz("macierz.txt")
        suma, sciezka = znajdz_maksymalna_sciezke(macierz)

        print(suma)
        print(sciezka)
    except FileNotFoundError:
        print("Nie znaleziono pliku macierz.txt")
    except Exception as e:
        print(f"Wystąpił błąd: {e}")

if __name__ == "__main__":
    main()