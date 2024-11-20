def z5_1():
	A = list(map(int,input("daj liczby (an - a0): ").split(" ")))
	x = float(input("x: "))
	n = len(A) - 1
	y = A[n]
	potega = 1

	for i in range(n,-1,-1):
		potega *= x
		y += A[i] * potega
	print(y)



def z5_2():
	A = list(map(int,input("daj liczby (An - A0): ").split(" ")))
	x = float(input("x: "))
	n = len(A)
	y = A[0]

	for i in range(1,n):
		y = x * y + A[i]
	print(y)