#Napisz program, który wczyta z pliku liczby.txt ciąg liczb,
# a następnie wyświetli ten ciąg posortowany metodą sortowania
# szybkiego zgodnie z powyższym pseudokodem.

def sortowanie_szybkie(ciag, lewy, prawy):
    i = lewy
    j = prawy
    pivot = ciag[(i+j)//2]
    while i<=j:
        while ciag[i]<pivot:
            i=i+1
        while ciag[j]>pivot:
            j=j-1
        if i<=j:
            pom = ciag[i]
            ciag[i] = ciag[j]
            ciag[j] = pom
            i=i+1
            j=j-1
    if j>lewy:
        sortowanie_szybkie(ciag, lewy, j)
    if i<prawy:
        sortowanie_szybkie(ciag, i, prawy)


plik = open("liczby.txt","r")
T = list(map(int,plik.read().split()))
plik.close()

sortowanie_szybkie(T,0,len(T)-1)
print(T)