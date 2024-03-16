# #PRE
# # from math import gcd /////print(gcd(12,16)) ///// gcd == nwd

# #1. wybór 2 dużych liczb pierwszych
# p=97
# q=101
                                                                          
# # print(p)
# # print(q)
# #2. stworzenie funkcji F = (p-1)*(q-1) #znalezienie n
# F = (p-1)*(q-1)#120

# n= p * q#143
# # print(n)
# # print(F)
# #znalezienie klucza publicznego e: NWD (F,e)=1
# from math import gcd

# for i in range(2,F):
#   if gcd(i,F)==1:
#     e = i
#     break
# # print(e)
# # print(e,n)
# #4. wygenerowanie klucza prywatnego d: d*e mod F = 1 (odwrotność modulo)
# for j in range(3,n,2):
#   if (j * e) % F == 1:
#     d = j
#     break
# # print(d,n)

# #przykład działania:
# # c = x**c mod n (na szyfrogram)
# # t = c**d mod n (na tekst jawny)
# msg = input()
# szyfrogram = ""

# for i in msg:
#   print((ord(i)**e) % n, end=" ")
#   szyfrogram+=chr((ord(i)**e)%n)
# print(szyfrogram)

# jawny=""
# for j in szyfrogram:
#   jawny += chr((ord(j)**d)%n)
# print(jawny)













