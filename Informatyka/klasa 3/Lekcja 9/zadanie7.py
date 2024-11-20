a = input("Liczba w jakims systemie:")
p = int(input("system:"))
A = []
for i in range(len(a),0,-1):
    A.append(int(a[i-1]))

n = len(A) - 1
y = A[0]
potega = 1

for i in range(1,n+1):
    potega *= p
    y += A[i] * potega
print("w dziesiętnym: ", y)