#python_karta_pracy_zadanie_domowe
#zad1
a, b = int(input()), int(input())
if ((a+b)%2 == 0):
    print("suma tych liczb jest parzysta")
    else
    print("suma tych liczb nie jest parzysta")

#zad2
from math import sqrt
a, b = int(input()), int(input())
if ((a+b)/2) > sqrt(a*b):
    print('średnia arytmetyczna jest większa')
else:
    print('srednia geometryczna jest większa')

#zad3
k = int(input('podaj pierwszą liczbę całkowitą:'))
l = int(input('podaj drugą liczbę całkowitą:'))
m = int(input('podaj trzecią liczbę całkowitą:'))
if k == l:
    print('1 liczba jest równa drugiej')
elif l == m:
    print('druga liczba jest równa trzeciej')
elif k == m:
    print('pierwsza liczba jest równa trzeciej')
else:
    print('nie')

#zad4
print('podaj 4 RÓŻNE liczby')
a = int(input())
b = int(input())
c = int(input())
d = int(input())
if a < b and a < c and a < d:
    print('a jest najmniejsze')
elif b < a and b < c and b < d:
    print('b jest najmniejsze')
elif c < a and c < b and c < d:
    print('c jest najmniejsze')
elif d < a and d < b and d < c:
    print('d jest najmniejsze')
else:
    print('podano takie same liczby')

#zad5
a = int(input())
b = int(input())
c = int(input())
if a+b<c or a+c<b or b+c<a:
    print("liczby nie spełniają nierówności trójkąta")
else:
    print('liczby spełniają nierówność trójkąta')

#zad6
a = int(input())
b = int(input())
c = int(input())
if a < b + c and b < a + c and c < a + b:
    print("Trójkąt powstanie")
     if a**2 + b**2 == c**2 or b**2 + c**2 == a**2 or c**2 + a**2 == b**2 : print("Będzie to trójkąt prostokątny")
    elif a**2 + b**2 < c**2 or b**2 + c**2 < a**2 or c**2 + a**2 < b**2 : print("Będzie to trójkąt rozwartokątny")
    elif a**2 + b**2 > c**2 or b**2 + c**2 > a**2 or c**2 + a**2 > b**2 : print("Będzie to trójkąt ostrokątny")
else:
    print("Trójkąt nie powstanie")
a = int(input())
b = int(input())
if a+b%2 == 0
        






