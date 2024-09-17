from math import sqrt
def czy_pierwsza(n):
    if n < 2: return False
    p = int(sqrt(n))
    for i in range(2,p+1):
        if n%i==0: return False
    return True


plik = open("liczby1.txt","r")
tab = list(map(int,plik.read().split()))

ile = 0

for liczba in tab:
    if czy_pierwsza(liczba): ile +=1
print(ile)


plik.close()