# Zadanie 8*: Program znajdujący najdłuższy wspólny spójny podciąg (substring, nie subsequence)
# oraz jego długość dla dwóch napisów podanych przez użytkownika

slowo1 = input("Podaj pierwsze słowo: ")
slowo2 = input("Podaj drugie słowo: ")

n = len(slowo1)
m = len(slowo2)

# Tworzenie tablicy dynamicznej
# dp[i][j] = długość najdłuższego wspólnego suffiksu slowo1[0..i-1] i slowo2[0..j-1]
dp = [[0] * (m + 1) for _ in range(n + 1)]

max_length = 0
ending_pos = 0  # pozycja końcowa najdłuższego wspólnego podnapisu w slowo1

# Wypełnianie tablicy
for i in range(1, n + 1):
    for j in range(1, m + 1):
        if slowo1[i - 1] == slowo2[j - 1]:
            dp[i][j] = dp[i - 1][j - 1] + 1
            if dp[i][j] > max_length:
                max_length = dp[i][j]
                ending_pos = i
        else:
            dp[i][j] = 0  # Różnica od LCS - musi być ciągły

# Odtworzenie najdłuższego wspólnego spójnego podciągu
if max_length > 0:
    substring = slowo1[ending_pos - max_length:ending_pos]
    print(f"Najdłuższy wspólny spójny podciąg: {substring}")
    print(f"Długość: {max_length}")
else:
    print("Brak wspólnego spójnego podciągu")
    print("Długość: 0")
# Zadanie 4: Program wyświetlający długość najdłuższego wspólnego podciągu dla dwóch słów

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

print("Długość najdłuższego wspólnego podciągu:", dp[n][m])

