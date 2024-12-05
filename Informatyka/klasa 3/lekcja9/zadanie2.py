A = list(map(int,input("daj liczby (A0 - An): ").split(" ")))
x = float(input("x: "))
n = len(A) - 1
y = A[n]

for i in range(n-1,-1,-1):
	y = x * y + A[i]
print(y)