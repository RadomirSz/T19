A = list(map(int,input("daj liczby: ").split(" ")))
x = float(input("x: "))
n = len(A) - 1
y = A[0]
potega = 1

for i in range(1,n+1):
	potega *= x
	y += A[i] * potega
print(y)