# wyświetli największą sumę wartości znajdujących się w jednej kolumnie
# oraz po spacji indeks pierwszej kolumny o największej sumie.

def wczytaj_macierz(nazwa_pliku):
    macierz = []
    with open(nazwa_pliku, 'r') as plik:
        for linia in plik:
            wiersz = [int(x) for x in linia.strip().split()]
            macierz.append(wiersz)
    return macierz

macierz = wczytaj_macierz("macierz.txt")

kolumny = [[] for i in range(len(macierz[0]))]

for i in range(len(macierz[0])):
    for j in range(len(macierz[i])):
        kolumny[j].append(macierz[i][j])


sumy_kolumn = []
for i, kolumna in enumerate(kolumny):
    suma_kolumny = sum(kolumna)
    sumy_kolumn.append(suma_kolumny)
    if(i==0): maks = suma_kolumny
    if(maks < suma_kolumny):
        maks = suma_kolumny

print(maks)
print(sumy_kolumn.index(maks))