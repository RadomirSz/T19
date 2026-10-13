def nwd(a,b):
    while b>0:
        reszta = a%b
        a = b
        b = reszta
    return a

plik = open("dron.txt","r")




print("3.2")

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