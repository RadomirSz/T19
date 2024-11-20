print("Zadanie 1")
ciag = list(map(int, input("Podaj wspolczynniki od a0 do an: ").split()))
x = float(input("Podaj x: "))
n = len(ciag) - 1

y = ciag[n]
for i in range(n-1, 0, -1):
    y = x * y + ciag[i]
print(y)