#Napisz program, który wczyta z pliku liczby.txt ciąg liczb,
# a następnie wyświetli ten ciąg posortowany metodą sortowania
# szybkiego zapisując wynik podziału listy w nowych listach.

def sortowanie_szybkie(ciag):
    n = len(ciag)
    if n<2:
        return ciag
    pivot = ciag[n//2]
    lewy = [x for x in ciag if x < pivot]
    srodek = [x for x in ciag if x == pivot]
    prawy = [x for x in ciag if x > pivot]
    return sortowanie_szybkie(lewy) + srodek + sortowanie_szybkie(prawy)

plik = open("liczby.txt","r")
T = list(map(int,plik.read().split()))
plik.close()
print(sortowanie_szybkie(T))