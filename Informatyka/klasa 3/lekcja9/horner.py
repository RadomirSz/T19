A = list(map(int,input()))
x = float(input())
n = len(A) - 1
y = A[0]
potega = 1

for i in range(1,n+1):
	potega *= x
	y += A[i] * potega
print(y)

#reku
def Schemat_Hornera(A,x):
    n = len(A)-1
    if n==0: return A[0]
    return x * Schemat_Hornera(A[1:],x) + A[0]


A = list(map(int,input("daj liczby (A0 - An): ").split(" ")))
x = float(input("x: "))

w = Schemat_Hornera(A,x)
print(w)