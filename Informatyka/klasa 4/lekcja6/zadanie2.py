
# Zadanie 2: Program wyświetlający długość najdłuższego wspólnego podciągu dla dwóch ciągów liczb

ciag1 = list(map(int, input("Podaj pierwszy ciąg liczb rozdzielonych spacjami: ").split()))
ciag2 = list(map(int, input("Podaj drugi ciąg liczb rozdzielonych spacjami: ").split()))

n = len(ciag1)
m = len(ciag2)

# Tworzenie tablicy do przechowywania długości najdłuższych wspólnych podciągów
dp = [[0] * (m + 1) for _ in range(n + 1)]

# Wypełnianie tablicy według algorytmu LCS
for i in range(1, n + 1):
    for j in range(1, m + 1):
        if ciag1[i - 1] == ciag2[j - 1]:
            dp[i][j] = dp[i - 1][j - 1] + 1
        else:
            dp[i][j] = max(dp[i - 1][j], dp[i][j - 1])

print("Długość najdłuższego wspólnego podciągu to:", dp[n][m])

