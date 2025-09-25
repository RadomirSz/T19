# Zadanie 5
import random

n = int(input("Podaj rozmiar macierzy n: "))

M = []
for _ in range(n):
    row = []
    for _ in range(n):
        row.append(random.randint(1, 10))
    M.append(row)

print("Wygenerowana macierz:")
for row in M:
    print(*row)

i, j = 0, 0
suma = M[i][j]

while i < n - 1 or j < n - 1:
    if i == n - 1:
        j += 1
    elif j == n - 1:
        i += 1
    else:
        if M[i + 1][j] > M[i][j + 1]:
            i += 1
        else:
            j += 1
    suma += M[i][j]

print("Maksymalna suma:", suma)
