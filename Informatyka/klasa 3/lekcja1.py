def czyPodzielnaPrzez2(n):
    return n%2==0

def czyPierwsza(n):
    for i in range(2,n):
        if n%i==0: return False
    return True
        
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

if czyPierwsza(p) and czyPierwsza(l):
    if p-l== -2 or p-l==2: print("są liczbami bliźniaczymi")
    else: print("nie są")
    






    
