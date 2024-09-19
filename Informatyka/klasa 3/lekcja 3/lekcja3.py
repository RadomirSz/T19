from math import sqrt
def czy_pierwsza(n):
    if n < 2: return False
    p = int(sqrt(n))
    for i in range(2,p+1):
        if n%i==0: return False
    return True

def dzielniki_wlasciwe(n):
    ile = 0
    for i in range(1,n):
        if(n%i==0):
            ile+=1
    return ile

def suma_dzielnikow_pierwszych(n):
    suma = 0
    for i in range(2,n+1):
        if(n%i==0 and czy_pierwsza(i)):
            suma += i
    return suma

def suma_czynników_pierwszych(n):
    czynnik = 2
    suma = 0
    while n>1:
        while n % czynnik == 0:
            suma += czynnik
            n //= czynnik
        czynnik += 1

plik = open("liczby1.txt","r")
tab = list(map(int,plik.read().split()))

ile = 0
for liczba in tab:
    if czy_pierwsza(liczba): ile +=1
#print(ile)


plik.close()


plik2 = open("liczby2.txt","r")
tab2 = list(map(int,plik2.read().split()))


#z2
#for i in tab2:
#    if(i%2==0): print(i)

#z3
suma = 0
for liczba in tab2:
    suma += dzielniki_wlasciwe(liczba)
#print(suma)


#z4

najwiekszaSuma = 0
liczba = 0
for i in tab2:
    if(suma_dzielnikow_pierwszych(i) > najwiekszaSuma):
        najwiekszaSuma = suma_dzielnikow_pierwszych(i)
        liczba = i
#print(liczba)

#z5

sumy_czynnikow = []
for liczba in tab2:
    sumy_czynnikow.append(suma_czynników_pierwszych(liczba))

minimum = min(sumy_czynnikow)

liczby = []
for i in tab2:
    if(suma_czynników_pierwszych(i) == minimum):
        liczby.append(i)
#print(liczby)



plik2.close()