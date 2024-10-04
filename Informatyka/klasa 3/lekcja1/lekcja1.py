def czyPodzielnaPrzez2(n):
    return n%2==0

def czyPierwsza(n):
    for i in range(2,n):
        if n%i==0: return False
    return True

def suma_dzielnikow_wlasciwych(n):
    suma = 0
    for i in range(1,n):
        if(n%i==0): suma +=i
    return suma

def czy_zaprzyjaznione(a,b):
    if a == b: print("nie")
    if(suma_dzielnikow_wlasciwych(a) == b and suma_dzielnikow_wlasciwych(b) == a): print("tak")
    else: print("nie")

def czy_blizniacze(a,b):
    if czyPierwsza(p) and czyPierwsza(l):
        if p-l== -2 or p-l==2: return True
        else: return False
    else: return False


#1
print("zad 1")

n = int(input())
if czyPodzielnaPrzez2(n): print("tak")
else: print("nie")

#2
print("zad 2")

a = int(input("podaj liczbe calkowita"))
print(f"dzielniki {a}: ")
for i in range(1,a+1):
    if a%i==0: print(i)

#3
print("zad 3")

suma = 0
x = int(input())
for i in range(1,x+1):
    if x%i==0: suma += i
print(suma)

#4
print("zad 4")

ilosc = 0
y = int(input())
for i in range(1,y+1):
    if y%i==0: ilosc += 1
print(ilosc)

#5
print("zad 5")

k = int(input())
for i in range(1,k+1):
    if k%i==0 and czyPierwsza(i): print(i)

#6
print("zad 6")
p = int(input())
l = int(input())

czy_blizniacze(p,l)
    
#7
print("zad 7")
h = int(input())

if(suma_dzielnikow_wlasciwych(h) == h): print("tak")
else: print("nie")


#8
print("zad 8")

o = int(input())
g = int(input())

czy_zaprzyjaznione(o,g)

#9
print("zad 9")

for i in range(1,1001):
    for j in range(1,1001):
        if(czy_blizniacze(i,j)):
            print(f"{i},{j}")

#10
print("zad 10")

for i in range(1,1001):
    if(suma_dzielnikow_wlasciwych(i) == i): print(i)
