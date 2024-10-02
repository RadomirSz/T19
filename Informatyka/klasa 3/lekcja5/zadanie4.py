

plik = open("liczby.txt","r")
liczby = list(map(int,plik.read().split()))
plik.close()


czy_pierwsza = [True]*1001
for i in range(2,1001):
    czy_pierwsza[i] = True

p = 2
while p*p <= 1000:
    if czy_pierwsza[p]:
        for i in range(p*p,1001,p):
            czy_pierwsza[i] = False
    p += 1

tab = []
for i in range(2,1001):
    if czy_pierwsza[i]:
        tab.append(i)

ilosc = 0
for i in liczby:
    if i in tab:
        ilosc +=1
print(ilosc)

