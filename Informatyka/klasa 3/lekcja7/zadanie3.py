import random


plik = open("losowe.txt","w")
for i in range(10):
    n = random.randint(1,101)
    plik.write(str(n) + "\n")
    print(n)
plik.close()
plik = open("losowe.txt","r")
tab = list(map(int,plik.read().split()))
suma = 0
srednia = 0
maks = 0
mini = 101
for i in tab:
    suma += i
    srednia += i/len(tab)
    if i > maks: maks = i
    if i < mini: mini = i

print(suma , " " , mini ," ", maks ," ", srednia)
plik.close()