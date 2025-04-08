# Napisz program obliczający sumę dwóch liczb w systemie o podstawie p (p w zakresie od 2 do 9).
# Liczby i podstawa są podawane przez użytkownika. Wynik podaj w systemie o podstawie p.

p = int(input("Podaj podstawę systemu (od 2 do 9): "))
a = input(f"Podaj pierwszą liczbę w systemie o podstawie {p}: ")
b = input(f"Podaj drugą liczbę w systemie o podstawie {p}: ")

a_decimal = int(a, p)
b_decimal = int(b, p)

suma_decimal = a_decimal + b_decimal

suma_p = ""
while suma_decimal > 0:
    suma_p = str(suma_decimal % p) + suma_p
    suma_decimal //= p

print(f"Suma liczb w systemie o podstawie {p} to: {suma_p}")