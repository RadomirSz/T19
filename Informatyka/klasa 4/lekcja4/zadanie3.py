macierz = []
with open("macierz.txt", 'r') as plik:
    for linia in plik:
        wiersz = [int(x) for x in linia.strip().split()]
        macierz.append(wiersz)

k1, k2 = 2, 4
if macierz and len(macierz[0]) > max(k1, k2):
    for wiersz in macierz:
        wiersz[k1], wiersz[k2] = wiersz[k2], wiersz[k1]


for wiersz in macierz:
    for liczba in wiersz:
        if liczba < 10:
            print(" ", end="")
        print(liczba, end=" ")
    print()
