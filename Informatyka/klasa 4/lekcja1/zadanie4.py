
# v1
wartosci = [1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1]
symbole = ["M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"]

liczba = int(input("liczba [1 do 4000]: "))
rzymska = ""
i = 0

while liczba > 0:
    while liczba >= wartosci[i]:
        rzymska += symbole[i]
        liczba -= wartosci[i]
    i += 1

print("Liczba rzymska:", rzymska)


# v2 - bez nieregularnych liczb w talicach - nie dziala

# wartosci = [1000, 500, 100, 50, 10, 5, 1]
# symbole  = ["M", "D", "C", "L", "X", "V", "I"]

# liczba = int(input("Podaj liczbę z przedziału [1, 4000]: "))

# rzymska = ""

# i = 0
# while liczba > 0:
#     # Sprawdzenie dla przypadków 900, 90, 9
#     if i < len(wartosci) - 2 and i % 2 == 0 and liczba >= wartosci[i] - wartosci[i+2]:
#         rzymska += symbole[i+2] + symbole[i]
#         liczba -= wartosci[i] - wartosci[i+2]
#     # Sprawdzenie dla przypadków 400, 40, 4
#     elif i < len(wartosci) - 1 and i % 2 == 1 and liczba >= wartosci[i] - wartosci[i+1]:
#         rzymska += symbole[i+1] + symbole[i]
#         liczba -= wartosci[i] - wartosci[i+1]
#     else:
#         # Standardowe odejmowanie (np. dla 300 = C+C+C)
#         ile_razy = liczba // wartosci[i]
#         if ile_razy > 0:
#             rzymska += symbole[i] * ile_razy
#             liczba -= wartosci[i] * ile_razy
#         i += 1

# print("Liczba rzymska:", rzymska)