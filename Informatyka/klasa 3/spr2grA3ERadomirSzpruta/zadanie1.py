
a = 1000

pierwsze = [False] * (a + 1)

for i in range(2,a):
    pierwsze[i] = True

p = 2

while p*p <= a:
    if pierwsze[p]:
        for i in range(p*p, a+1,p):
            pierwsze[p]  = False
    p+=1

plik = open("liczby.txt", "r")

plik1 = list(map(int,plik.read().split()))

plik.close()


wszystkie_pierwsze = 0
ilosc = 0

for i in plik1:
    ilosc += 1
    if(not pierwsze[i]):
        wszystkie_pierwsze+=1
print("w pliku jest", wszystkie_pierwsze, "liczb pierwszych i stanowią one", wszystkie_pierwsze/ilosc, "% wszystkich liczb")

