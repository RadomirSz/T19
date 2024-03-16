# # #hufmann
# # A="AABBCDDDDDV"
# # #2a2bc5d

# # H=""
# # ilosc=1
# # for i in range(len(A)-1):
# #   if A[i]==A[i+1]:
# #     ilosc+=1
# #   else:
# #     if ilosc > 1:
# #       H+=str(ilosc)
# #     H+=A[i]
# #     ilosc=1
# # if ilosc>1:
# #   H+=str(ilosc)
# # H+=A[len(A)-1]
# # print(H)








# # suma = 0
# # n = int(input())
# # for i in range(1,n-1):
# #   if n%i == 0:
# #     suma += i
# # print(suma)
# 1########################################
# from math import gcd
# p=11
# q=13

# F=(q-1)*(p-1)
# n=p*q
# #chcemy uzyskać klucze e i d

# #2######################################## klucze (jawny,prywatny)
# for i in range(2,F):
#   if gcd(i,F)==1:
#     e = i
#     break

# for i in range(3,n,2):
#   if (i * e) % F == 1:
#     d = i
#     break
# #3#######################################
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















# # p = 23
# # q = 29
# # F = (q-1)*(p-1)
# # n = p * q
# # for i in range(2,F):
# #   if gcd(i,F)==1:
# #     e = i
# #     break

# # for i in range(3,n,2):
# #   if ((i*e)%F)==1:
# #     d=i
# #     break


# # for i in range(3,n,2):
# #   if ((i*e)%F)==1:
# #     d = i
# #     break



# # from math import gcd
# # p= 11
# # q = 13
# # F = (q-1)*(p-1)
# # n = p*q
# # for i in range(2,F):
# #   if gcd(i,F)==1:
# #     e=i
# #     break
    
# # for i in range(3,n,2):
# #   if ((i*e)%F)==1:
# #     d=i
# #     break






# # from math import gcd
# # p=11
# # q=13
# # F=(q-1)*(p-1)
# # n=p*q
# # for i in range(2,F):
# #   if gcd(i,F)==1:
# #     e=1
# #     break

# # for i in range(3,n,2):
# #   if ((i*e)%F)==1:
# #     d=i
# #     break














# # from math import gcd
# # p=11
# # q=13
# # F=(p-1)*(q-1)
# # n=p*q
# # for i in range(2,F):
# #   if gcd(i,F)==1:
# #     e=i
# #     break
    
# # for i in range(3,n,2):
# #   if ((i*e)%F)==1:
# #     d=i
# #     break
    
# # msg=input()
# # kod=""

# # for i in msg:
# #   kod+=chr((ord(i)**e)%n)
# # print(kod)

# # jawny=""
# # for i in kod:
# #   jawny+=chr((ord(i)**d)%n)
# # print(jawny)















# from math import gcd
# q=11
# p=13
# F=(p-1)*(q-1)
# n=p*q

# for i in range(2,F):
#   if gcd(i,F)==1:
#     e=i
#     break
# for i in range(3,n,2):
#   if ((i*e)%F)==1:
#     d=i
#     break
# msg=input()
# kod=""
# for i in msg:
#   kod+=chr((ord(i)**e)%n)
# print(kod)
# jawny=""
# for i in kod:
#   jawny+=chr((ord(i)**d)%n)
# print(jawny)


#################### DANGER FOR COMPUTER ########################
# suma1 = 0
# suma2 = 0
# for i in range(1,5000):
#     for j in range(1,5000):
#         for k in range(1,i):
#             if i%k == 0:
#                 suma1 += k
#         for l in range(1,j):
#             if j%l==0:
#                 suma2+=l
#         if suma1 == j and suma2 == i:
#             print(f"liczby zaprzyjaźnione:{suma1},{suma2}")
# print()
################################################################

# from math import gcd
# q=11
# p=13
# F=(q-1)*(p-1)
# n=p*q

# for i in range(2,F):
#   if gcd(i,F)==1:
#     e = i
#     break

    
# for i in range(3,n,2):
#   if ((i*e)%F)==1:
#     d=i
#     break
    
# msg = input()
# kod=""
# jawny=""

# for i in msg:
#   kod+=chr((ord(i)**e)%n)
# print(kod)

# for i in kod:
#   jawny+=chr((ord(i)**d)%n)
# print(jawny)


# #nww
# a = 123
# b = 45

# # from math import lcm 
# # lcm(a,b)
# # while b!=a:
# #   if a>b: b+=a
# #   if b>a: a+=b
# # print(a,b)
# r=a*b
# while b>0:
#   a,b = b,a%b
# print(a)
# print(r/a)



# from math import gcd
# q=11
# p=13
# F=(p-1)*(q-1)
# n=q*p
# for i in range(2,F):
#   if gcd(i,F)==1:
#     e=i
#   break
# for i in range(3,n,2):
#   if ((i*e)%F)==1:
#     d=i
#     break

# msg=input()
# kod=""
# for i in msg:
#   kod+=chr((ord(i)**e)%n)
# print(kod)
# jawny=""
# for i in kod:
#   jawny+=chr((ord(i)**d)%n)
# print(jawny)

