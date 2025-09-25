plik = open("macierz.txt", "r")

M = [list(map(int, line.split())) for line in plik]

n = len(M)
i, j = 0, 0
suma = M[i][j]
path = [(i, j)]

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
    path.append((i, j))

print(suma)
for p in path:
    print(p[0], p[1])