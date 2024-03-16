#1. algorytm sprawdzający czy liczba jest pierwsza
#ma dwa dzielniki np 2,3,5,7,11,13,17 itd...
# n = int(input())
# for i in range(2,n-1):
#   if n%i == 0:
#     print('nie jest pierwsza')
#     exit(0)
# print('jest pierwsza')

# #wersja 2
# from math import sqrt
# n = int(input())
# flaga = True
# for i in range(2,sqrt(n)+1,):
#   if n%i == 0:
#     flaga=False
# if flaga == True:
#   print('pierwsza')
# else:
#   print('nie pierwsza')

#2. generator liczb pierwszych - liczby w przedziale [p,q]
p , q = map(int, input().split())

for i in range(p, q+1):
  flaga=True
  for j in range(2,int(i**0.5)+1):
    if i % j==0:
      flaga = False
  if flaga:
    print(i, end=" ")

#3. generator liczb pierwszych - początkowe k liczb pierwszych
n = int(input('ile? '))
x = 2
while 1:
  flaga = True
  for i in range(2, int(x**0.5)+1):
    if x % i == 0:
      flaga=False
  if flaga:
    print(x, end=" ")
    n = n-1
    if n == 0:
       break
  x = x + 1
