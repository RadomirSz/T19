# Zadanie 1: Wypełnienie macierzy w arkuszu kalkulacyjnym Excel
# dla słów PROGRAMY i ALGORYTMY zgodnie z przykładem z lekcji

# To zadanie wymaga użycia programu Excel lub innego arkusza kalkulacyjnego.
# Poniżej przedstawiam macierz w formie tekstowej oraz kod generujący ją w Pythonie:

slowo1 = "ALGORYTMY"
slowo2 = "PROGRAMY"

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

# Wyświetlanie macierzy
print("Macierz dla LCS słów '{}' i '{}':".format(slowo1, slowo2))
print()

# Nagłówek
print("     ", end="")
for char in slowo2:
    print(f"{char:3}", end="")
print()

# Wiersze z danymi
for i in range(n + 1):
    if i == 0:
        print("  ", end="")
    else:
        print(f"{slowo1[i-1]} ", end="")

    for j in range(m + 1):
        print(f"{dp[i][j]:3}", end="")
    print()

print()
print(f"Najdłuższy wspólny podciąg: długość = {dp[n][m]}")

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

lcs.reverse()
print(f"Najdłuższy wspólny podciąg: {''.join(lcs)}")

