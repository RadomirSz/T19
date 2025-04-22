dec = int(input("Podaj liczbę dziesiętną: "))
result = ""

while dec > 0:
    result = str(dec % 2) + result
    dec //= 2

print(result)