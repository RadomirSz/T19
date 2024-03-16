#zad1 - Napisz pętle wypisujacą dni miesiąca listopada 2022 roku
for i in range(0,31):
    print(i, end=" ")
#zad2 - Napisz pętle wypisujacą kwadraty cyfr nieparzystych
for i in range(1,10,2):
    print(i**2, end=" ")
#zad3 - Napisz pętle wypisującą liczby czterocyfrowe dzielące się przez 379
for i in range(1000,10000):
  if (i%379 == 0):
    print(i, end=" ")
#zad4 - Napisz pętle wypisującą liczby trzycyfrowe podzielne przez 5, 6 lub ewentualnie 11
for i in range(100,1000):
    if (i%5 == 0 or i%6 == 0 or i%11 == 0):
        print(i, end=" ")
#zad5 - Napisz program, który podaje sumę wpisanych przez usera liczb. User najpierw podaje ile liczb poda, a potem w pętli te liczby są czytane.
suma = 0
a = int(input("ile liczb chcesz wpisać? "))
for i in range(0,a):
  x = int(input("podaj liczbę "))
  suma+=x
print(suma)
#zad6 program wyznaczający sumę k początkowych liczb parzystych 
k = int(input("Ile liczb parzystych dodać? "))
suma = 0
for i in range(1,k*2+1):
  if i%2 == 0:
    suma+=i
print(suma)
#zad7 - napisz program wyznaczający sumę m dwucyfrowych liczb nieparzystych
m = int(input("Ile liczb dwucyfrowych nieparzystych dodać? "))
suma = 0
for i in range(11,m*2+1+10,2):
    suma+=i
print(suma)
#zad8
w = int(input("podaj kwotę wejściową: "))
l= int(input("Ile lat trwała inwestycja? "))
wk = 0
sk = w
for i in range(0,l*12):
  wk =sk*0.06*(1/12)
  sk+=wk
print(round(sk,2))

#zad9
suma = 0
lista = 21
n = int(input("podaj ilośc razy: "))
for i in range(21,(n*100)+21,100):
  print(lista)
  suma+=i
  lista+=100
print(suma)

#zad10
from math import sqrt
for i in range(1,1001):
  if i%10 ==sqrt(i) or i%100 == sqrt(i) or i%1000 == sqrt(i):
    print(i, end=" ")
