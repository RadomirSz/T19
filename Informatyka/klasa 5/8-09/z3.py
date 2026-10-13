def nwd(a, b):
    a = abs(a)
    b = abs(b)
    while b > 0:
        a, b = b, a % b
    return a


def zadanie_31(nazwa_pliku):
    wynik = 0
    with open(nazwa_pliku, "r") as plik:
        for linia in plik:
            linia = linia.strip()
            if not linia:
                continue
            a, b = map(int, linia.split())
            if nwd(a, b) > 1:
                wynik += 1
    return wynik
print("3.1")
print(zadanie_31("dron.txt"))





print("3.2")
plik = open("dron.txt","r")
punkty=[]
x=0
y=0
ile=0
for linia in plik:
    linia = linia.rstrip()
    a,b = linia.split()
    x += int(a)
    y += int(b)
    punkty.append([x,y])
    if 0<x<5000 and 0<y<5000:
        ile += 1
# print(punkty)
print(ile)
n = len(punkty)
for i in range(n):
    for j in range(i+1,n):
        xs = (punkty[i][0] + punkty[j][0])/2
        ys = (punkty[i][1] + punkty[j][1])/2
        if [xs,ys] in punkty:
            print(f"({punkty[i][0]},{punkty[i][1]}), ({xs},{ys}), ({punkty[j][0]},{punkty[j][1]})")

plik.close()