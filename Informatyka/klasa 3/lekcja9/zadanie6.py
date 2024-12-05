a = input("Liczba w systemie binarnym:")
A = []
for i in range(len(a),0,-1):
    A.append(int(a[i-1]))

n = len(A) - 1
y = A[0]
potega = 1

for i in range(1,n+1):
    potega *= 2
    y += A[i] * potega
print(y)