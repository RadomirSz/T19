plik = open("dane.txt", "r")
nominaly = list(map(int,plik.readline().split()))
kwoty = list(map(int,plik.read().split()))
plik.close()

def liczba_banknotow(nominaly, kwota):
    liczba_banknotow = 0
    for nominal in nominaly:
        while kwota >= nominal:
            kwota -= nominal
            liczba_banknotow += 1
    return liczba_banknotow

liczbyNominalow = []
min = liczba_banknotow(nominaly, kwoty[0])

for kwota in kwoty:
    x = liczba_banknotow(nominaly, kwota)
    liczbyNominalow.append(x)

    if(x<min):
        min = x

for i in range(len(liczbyNominalow)):
    if(liczbyNominalow[i] == min):
        print(kwoty[i])


