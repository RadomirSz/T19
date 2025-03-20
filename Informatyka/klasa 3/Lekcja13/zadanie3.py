# Zmodyfikuj program z zadania 2 tak, aby wyznaczając
# elementy mniejsze, równe oraz większe od pivota
# zastosować tylko jedną pętlę for.

def sortowanie_szybkie(ciag):
    n = len(ciag)
    if n<2:
        return ciag
    pivot = ciag[n//2]
    lewy = []
    srodek = []
    prawy = []
    for x in ciag:
        if x < pivot:
            lewy.append(x)
        elif x == pivot:
            srodek.append(x)
        elif x > pivot:
            prawy.append(x)
    return sortowanie_szybkie(lewy) + srodek + sortowanie_szybkie(prawy)

plik = open("liczby.txt","r")
T = list(map(int,plik.read().split()))
plik.close()
print(sortowanie_szybkie(T))
