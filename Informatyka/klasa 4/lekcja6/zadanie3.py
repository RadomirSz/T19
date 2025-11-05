# Zadanie 3: Program wyświetlający najdłuższy wspólny podciąg jako liczby rozdzielone spacjami

ciag1 = list(map(int, input("Podaj pierwszy ciąg liczb rozdzielonych spacjami: ").split()))
ciag2 = list(map(int, input("Podaj drugi ciąg liczb rozdzielonych spacjami: ").split()))

n = len(ciag1)
m = len(ciag2)

# Tworzenie tablicy dynamicznej
dp = [[0] * (m + 1) for _ in range(n + 1)]

# Wypełnianie tablicy
for i in range(1, n + 1):
    for j in range(1, m + 1):
        if ciag1[i - 1] == ciag2[j - 1]:
            dp[i][j] = dp[i - 1][j - 1] + 1
        else:
            dp[i][j] = max(dp[i - 1][j], dp[i][j - 1])

# Odtwarzanie najdłuższego wspólnego podciągu
lcs_length = dp[n][m]
lcs = []
i, j = n, m

while i > 0 and j > 0:
    if ciag1[i - 1] == ciag2[j - 1]:
        lcs.append(ciag1[i - 1])
        i -= 1
        j -= 1
    elif dp[i - 1][j] > dp[i][j - 1]:
        i -= 1
    else:
        j -= 1

# Odwracamy listę, bo budowaliśmy od końca
lcs.reverse()

print("Najdłuższy wspólny podciąg:", ' '.join(map(str, lcs)))
