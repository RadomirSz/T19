plik = open("nominaly.txt", "r")
nominaly = list(map(int, plik.readline().split()))
plik.close()

kwota = int(input("Podaj kwotę do wydania: "))
output = {}

for b in nominaly:
    ile = kwota // b
    if ile > 0:
        output[b] = ile
        kwota %= b

for nom, ile in output.items():
    print(f"{ile}x{nom}")
