# Zadanie 3

M = [
    [3, 7, 2, 6, 4],
    [5, 1, 9, 3, 8],
    [6, 2, 4, 7, 1],
    [8, 3, 5, 2, 9],
    [4, 6, 1, 5, 7] 
]

n = len(M)
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
