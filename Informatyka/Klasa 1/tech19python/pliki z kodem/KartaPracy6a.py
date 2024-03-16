print('helo')
#z1
# suma = 0
# x = int(input())
# a = x
# while a>0:
#   suma = suma + a%10
#   x = x // 10
# print(suma)

#z2
# n = int(input())
# suma = 0
# while n>0:
#   suma = suma = n%10
#   n = n //10
# print(suma)

#zad3 6 28 496
# n = int(input())
# suma = 0 
# for i in range(1,n):
#   if n % i == 0:
#     suma = suma + i
# if suma == n:
#   print('jest')
# else:
#   print('nie')

# l = int(input())
# a, b = l, l
# x = a*b
# while b>0:
#   r = a%b
#   a = b
#   b = r
# if a != l/2 or a!=l/3:
#   print('jest pierwsza')
# else:
#   print('nie jest pierwsza')

# n = int(input())
# for i in range(10,20):
#   x= n
#   y = i
#   while y>0:
#     x, y = y, x%y
#   if x == 1:
#     print(f"para: {n}, {i}")


# #zad 6 
# a, b = int(input()), int(input())
# c, d = a, b
# x = a*b
# while b>0:
#   r = a%b
#   a = b
#   b = r
# #a nwd

# print(f"{c/a}{'/'}{d/a}")

# #6
# print("podaj licznik i mianownik:")
# a, b = int(input()), int(input())
# x,y=a,b
# while b>0:
#   r = a%b
#   a = b
#   b = r
# print(f"nwd:{a}")
# if a == 1:
#   print('ułamka nie da się skrócić')
# print(x/a)
# print(y/a)

#7
# liczba = 0
# a,b = int(input()), int(input())
# while b<a:
#   a = a - b
#   liczba +=1
# if a<b:
#   print(f"liczba po wyłączeniu całości: {liczba} {a}/{b}")
# else:
#   print(f"liczba po wyłączeniu całości: {liczba+1}")

#zad 8
# T = []
# for i in range(2,10000):
#   suma = 0
#   for j in range(1,i):
#     if i%j == 0:
#       suma += j
#   suma2 = 0
#   for k in range(1,suma):
#     if suma % k == 0:
#       suma2 +=k
#     if i == suma2 and suma !=suma2 and suma2 not in T:
#       print(f"{suma},{suma2}")

# def czy_pierwsza(n):
#   for i in range(2,n):
#     if n%i == 0:
#       return False
#   return True

# for i in range(10,100):
#   for j in range(2,i):
#     if i%j == 0:
#       if czy_pierwsza(j) and czy_pierwsza(i//j):
#         print(i, end =" ")
#         break