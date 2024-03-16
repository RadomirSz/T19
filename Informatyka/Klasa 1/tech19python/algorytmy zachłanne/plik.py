+# n = int(input())
# a = n
# T = [500,200,100,50,20,10,5,2,1]
# Y = []
# for i in T:
#   while a>0:
#     if T[i]<a:
#       a-=T[i]
#       Y+=str(T[i])
# print(Y)

#wersja1
n = int(input())
T=[50,20,10,5,2,1]
# for i in T:
#   ilosc=n//i
#   n = n - ilosc * i
#   print(f"Nominał {i} ilość {ilosc}")

#wersja z tablicą wyników
W=[]
for i in T:
  ilosc = n//i
  if ilosc>0:
    n=n-ilosc*i
    for j in range(ilosc):
      W.append(i)
#      opcjonalne zamiast append w pętli for: W += ilosc * [i]
print(W)