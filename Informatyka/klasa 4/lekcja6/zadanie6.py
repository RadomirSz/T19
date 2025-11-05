# Zadanie 6: Program wyświetlający pary słów z pliku, gdzie LCS jest najdłuższy
# Jeżeli jest kilka takich par, wyświetlić wszystkie z nich

# Wczytanie par słów z pliku
with open('pary.txt', 'r', encoding='utf-8') as plik:
    pary = [linia.strip().split() for linia in plik if linia.strip()]

def lcs_length(slowo1, slowo2):
    """Funkcja zwracająca długość najdłuższego wspólnego podciągu"""
    n = len(slowo1)
    m = len(slowo2)

    dp = [[0] * (m + 1) for _ in range(n + 1)]

    for i in range(1, n + 1):
        for j in range(1, m + 1):
            if slowo1[i - 1] == slowo2[j - 1]:
                dp[i][j] = dp[i - 1][j - 1] + 1
            else:
                dp[i][j] = max(dp[i - 1][j], dp[i][j - 1])

    return dp[n][m]

# Znajdowanie maksymalnej długości LCS
max_lcs = 0
wyniki = []

for para in pary:
    if len(para) == 2:
        slowo1, slowo2 = para
        dlugosc = lcs_length(slowo1, slowo2)
        wyniki.append((slowo1, slowo2, dlugosc))
        if dlugosc > max_lcs:
            max_lcs = dlugosc

# Wyświetlanie par z maksymalną długością LCS
print(f"Najdłuższy wspólny podciąg ma długość: {max_lcs}")
print("Pary słów z najdłuższym wspólnym podciągiem:")
for slowo1, slowo2, dlugosc in wyniki:
    if dlugosc == max_lcs:
        print(f"{slowo1} {slowo2}")

