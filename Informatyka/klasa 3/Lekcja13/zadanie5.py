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

def sortowanie_szybkie2(ciag):
    n = len(ciag)
    if n < 2:
        return ciag
    pivot = ciag[n // 2]
    lewy = [x for x in ciag if x < pivot]
    srodek = [x for x in ciag if x == pivot]
    prawy = [x for x in ciag if x > pivot]
    return sortowanie_szybkie2(lewy) + srodek + sortowanie_szybkie2(prawy)

from random import randint
T = []
for i in range(1000000):
    T.append(randint(0,1000000))
