def wczytaj_macierz(nazwa_pliku):
    macierz = []
    with open(nazwa_pliku, 'r') as plik:
        for linia in plik:
            wiersz = [int(x) for x in linia.strip().split()]
            macierz.append(wiersz)
    return macierz

def zamien_kolumny(macierz, k1, k2):
    # Sprawdzamy, czy macierz ma wystarczającą liczbę kolumn
    if macierz and len(macierz[0]) > max(k1, k2):
        for wiersz in macierz:
            wiersz[k1], wiersz[k2] = wiersz[k2], wiersz[k1]
    return macierz

def wypisz_macierz(macierz):
    for wiersz in macierz:
        for liczba in wiersz:
            # Dodaj spację przed liczbami jednocyfrowymi
            if liczba < 10:
                print(" ", end="")
            print(liczba, end=" ")
        print()  # Nowa linia po każdym wierszu

def main():
    try:
        macierz = wczytaj_macierz("macierz.txt")
        macierz = zamien_kolumny(macierz, 2, 4)
        wypisz_macierz(macierz)
    except FileNotFoundError:
        print("Nie znaleziono pliku macierz.txt")
    except Exception as e:
        print(f"Wystąpił błąd: {e}")

if __name__ == "__main__":
    main()