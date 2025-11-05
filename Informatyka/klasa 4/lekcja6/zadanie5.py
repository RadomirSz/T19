# Zadanie 5: Program wyświetlający najdłuższy wspólny podciąg dla dwóch słów

slowo1 = input("Podaj pierwsze słowo: ")
slowo2 = input("Podaj drugie słowo: ")

n = len(slowo1)
m = len(slowo2)

# Tworzenie tablicy dynamicznej
dp = [[0] * (m + 1) for _ in range(n + 1)]

# Wypełnianie tablicy
for i in range(1, n + 1):
    for j in range(1, m + 1):
        if slowo1[i - 1] == slowo2[j - 1]:
            dp[i][j] = dp[i - 1][j - 1] + 1
        else:
            dp[i][j] = max(dp[i - 1][j], dp[i][j - 1])

# Odtwarzanie najdłuższego wspólnego podciągu
lcs = []
i, j = n, m

while i > 0 and j > 0:
    if slowo1[i - 1] == slowo2[j - 1]:
        lcs.append(slowo1[i - 1])
        i -= 1
        j -= 1
    elif dp[i - 1][j] > dp[i][j - 1]:
        i -= 1
    else:
        j -= 1

# Odwracamy listę, bo budowaliśmy od końca
lcs.reverse()

print("Najdłuższy wspólny podciąg:", ''.join(lcs))

