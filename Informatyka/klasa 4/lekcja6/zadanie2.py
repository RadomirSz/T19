
# Zadanie 2: Program wyświetlający długość najdłuższego wspólnego podciągu dla dwóch ciągów liczb

def najdluzszy_wspolny_podciag(X, Y, n, m):
    # D = [[0] * (m + 1) for _ in range(n + 1)]
    D = [[0 for j in range(m + 1)] for i in range(n + 1)]
    for i in range(1, n + 1):
        for j in range(1, m + 1):
            if X[i - 1] == Y[j - 1]:
                D[i][j] = D[i - 1][j - 1] + 1
            else:
                D[i][j] = max(D[i - 1][j], D[i][j - 1])

    return D[n][m]

ciag1 = list(map(int,input("Podaj pierwszy ciąg: ").split()))
ciag2 = list(map(int,input("Podaj drugi ciąg: ").split()))
wynik = najdluzszy_wspolny_podciag(ciag1, ciag2, len(ciag1), len(ciag2))
print(f'Najdłuższy wspólny podciąg: "{wynik[1:]}"')