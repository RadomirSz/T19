#zad1
# n = int(input())
# for i in range(n):
#   print("*-|", end=" ")
#zad2
# n = int(input())
# for i in range(1, n+1):
#   print("*"*i,end="")
#   if i%2:
#     print("||",end="")
#   else:
#     print("--",end="")
#zad3
# n = int(input())
# for i in range(1,n+1):
#   print("*", end=" ")
#   if i%2==1:
#     print("|"*i,end=" ")
#   else:
#     print("-"*i, end=" ")
#PRE - tabliczka mnożenia
# \t to tabulator wyrównuje
# for i in range(1,11):
#   for j in range(1,11):
#     print(i*j,end="\t")
#   print()
#zad4
# n = int(input())
# for i in range(1,n+1):
#   for j in range(1,n+1,-1):
#     print("*")
#pre

# *
# **
# ***
# ****
# n = int(input())
# for i in range(n): #ilość wierszy
#   for j in range(i+1): #ilość kolumn
#     print("*", end=" ")
#   print()

#*
#**
#***
#****
#
#****
#***
#**
#*
# n = int(input())
# for i in range(n):  #ilość wierszy
#   for j in range(i + 1):  #ilość kolumn
#     print("*", end=" ")
#   print()

# print()
# print()

# for i in range(n):  #ilość wierszy
#   for j in range(n - i):  #ilość kolumn
#     print("*", end=" ")
#   print()

#    *
#   **
#  ***
# ****
#
# ****
#  ***
#   **
#    *

# n = int(input())

# for i in range(n):
#     for j in range(i + 1):
#         print("*", end="")
#     print()

# print()
# print()

# for i in range(n):
#     for j in range(n - i):
#         print("*", end="")
#     print()

# print()
# print()

# for i in range(n):
#     for j in range(n - i - 1):
#         print(" ", end="")
#     for k in range(n - i - 1, n):
#         print("*", end="")
#     print()

# print()
# print()

# for i in range(n):
#     for j in range(i):
#         print(" ", end="")
#     for k in range(i, n):
#         print("*", end="")
#     print()
# n=int(input())
# for i in range(n):
#   for j in range(n):
#     if i >=j:
#       print("*", end="")
#     else:
#       print(" ", end="")
#   print()

# print()
# print()
# #*****
# #****
# #***
# #**
# #*
# for i in range(n):
#   for j in range(n):
#     if j >=i:
#       print("*", end="")
#     else:
#       print(" ", end="")
#   print()

# print()
# print()
#n = int(input())
# for i in range(n):
#   for j in range(n):
#     if i==n-j-1 or i>j:
#       print("*", end="")
#     else:
#       print(" ", end="")
#   print()

# print()

# for i in range(n):
#   for j in range(n):
#     if i+j >= n - 1:
#       print("*", end="")
#     else:
#       print(" ", end="")
#   print()

# print()

# for i in range(n):
#   for j in range(n):
#     if i <= j:
#       print("*", end="")
#     else:
#       print(" ", end="")
#   print()

#zad5
# n = int(input())
# for i in range(n):
#   for j in range(n):
#     if j == n//2:
#       print("*", end="")
#     elif(i== n//2):
#       print("-", end="")
#     else:
#       print(" ", end="")
#   print()

#zad6
# n = int(input())
# for i in range(n):
#   for j in range(n):
#     if i+j == n-1:
#       print("?", end="\t")
#     elif i-j == 0:
#       print("*", end="\t")
#     else:
#       print("", end="\t")
#   print()

# p = int(input())
# k = int(input())
# s = int(input())
# print('a)')
# if k-p == s or k-p == 2*s or k-p == 3*s or k-p == 4*s or k-p == 5*s:
#   print('tak')
# else:
#   print('nie')

# print('b)')
# if k-p <=s:
#   print('1')
# elif(k-p<=s*2):
#   print('2')
# elif(k-p<=s*3):
#   print('3')
# elif(k-p<=s*4):
#   print('4')
# elif(k-p<=s*5):
#   print('5')
# else:
#   print('nie przeskoczy')

# print('c)')
# if (k-p == 5*s):
#   print('tak')
# else:
#   print('nie')

# print((k-p)/5)

# for i in range(1000,10000):
#   if (i%1000 == 2*(i%100) and i%100 == 2*(i%10)):
#     print(i)

#  for faj in range(1000,10000):
#    a = faj % 1000
#    b = faj % 100
#    c = faj % 10
#    if a * 2 == b and b * 2 == c:
#      print(faj)

# # xabc
# # 2*b=c
# # 2*a=b
# for faj in range(1000,10000):
#     jed = int(faj % 10)
#     dz = int((faj % 100)/10)
#     set = int((faj % 1000)/100)
#     if jed  == dz * 2 and dz  == set * 2 and jed * 2 < 10 and dz * 2 < 10:
#         print(faj)
#n = int(input())

# * *       * *
# * * *   * * *
#   * * * * *
#     * * *
#   * * * * *
# * * *   * * *
# * *       * *

# x = int(input())
# for i in range(x):
#   for j in range(x):
#     if j+i == x-1:
#       print('*', end=" ")
#     elif(i == j):
#       print("*", end=" ")
#     elif(i == j+1):
#       print("*", end=" ")
#     elif(i+1 == j):
#       print("*", end=" ")
#     elif(i+j == x):
#       print("*", end=" ")
#     elif(j+i==x-2):
#       print("*", end=" ")
#     else:
#       print(" ", end=" ")
#   print()

# n = int(input())
# for i in range(n):
#   for j in range(n):
#     if i+j == n-1:
#       print("?", end=" ")
#     elif i-j == 0:
#       print("*", end=" ")
#     else:
#       print("", end=" ")
#   print()

# n = int(input())
# for i in range(n):
#   for j in range(n):
#     if j+i == n-1:
#       print('#', end=" ")
#     elif(i==j):
#       print('#', end=" ")
#     elif(i==n/2):
#       print('*' ,end=" ")
#     elif(j==n/2):
#       print('*')
#     else:
#       print(' ', end=" ")
#   print()

# n = int(input())

# for i in range(9):
#   if n%2 == 0:
#     n = n/2
#   else:
#     n=n*3+1
#   print(n)
# if n == 1:
#   print("liczba która została podana na 9 miejscu w ciągu collatza to 1")
# else:
#   print("nie")

# a = int(input())
# b = int(input())
# c = int(input())
# d = int(input())
# print("a)")
# print((a+b+c+d)/4)
# print('b)')
# if a == d or a == d+1 or a == d+2 or a == d-1 or a == d-2:
#   print('tak')
# else:
#   print('nie')
# print('c)')
# if a<b and b<c and c<d:
#   print('3')
# elif a<b and b<c and not c<d:
#   print('2')
# elif a<b and not b<c and not c<d:
#   print('1')
# elif a<b and b<c and c<d:
#   print('2')
# elif not a<b and b<c and c<d:
#   print('2')
# elif not a<b and b<c and not c<d:
#   print('1')
# elif a<b and not b<c and c<d:
#   print('2')
# elif not a<b and not b<c and c<d:
#   print('1')
# else:
#   print('0')

# #           *           #
#   #         *         #
#     #       *       #
#       #     *     #
#         #   *   #
#           # * #
# * * * * * * * * * * * * *
#           # * #
#         #   *   #
#       #     *     #
#     #       *       #
#   #         *         #
# #           *           #
# x = int(input())
# for i in range(x):
#     for j in range(x):
#         if i == int(x/2) or j == int(x/2): print("*",end=" ")
#         elif j == i or i + j == x - 1: print("#",end=" ")
#         else: print(" ",end=" ")
#     print(" ")

#fajowe liczby
# for faj in range(1000,10000):
#     jed = int(faj % 10)
#     dz = int((faj % 100)/10)
#     set = int((faj % 1000)/100)
#     if jed  == dz * 2 and dz  == set * 2 and jed != 0:
#         print(faj)

# x = int(input())
# for i in range(x):
#   for j in range(x):
#     if  j == int(x/2):
#       print('*', end=" ")
#     elif(i == int(x/2)):
#       print('*', end=" ")
#     elif i+j == x-1:
#       print('#', end=" ")
#     elif(i == j):
#       print("#", end=" ")
#     else:
#       print(" ", end=" ")
#   print
# print('podaj kod trzycyfrowy')
# a = int(input())
# b = int(input())
# c = int(input())
# if a+2 > b or a+2 < b or b+2 > a or b+2 < a and b+2 > c or b+2 < c:
#     print('dobry kod')
# else:
#     print('zły kod')

# suma = 0
# l = 1
# n = int(input('podaj ile ułamków dodać: '))
# for i in range(n):
#   l = l+1
#   suma =suma + l/((i+1)**2)
# #  print(l , (1+i)**2)
# print("suma:")
# print(round(suma, 3))

# print('zad 1')
# print('podaj kod trzycyfrowy')
# a = int(input())
# b = int(input())
# c = int(input())
# if a+2 == b or a+1 == b or a == b or a-1 == b or a-2 == b and b+2 == c or b+1 == c or b == c or b-1 == c or b-2 == c:
#     print('zły kod')
# else:
#     print('dobry kod')