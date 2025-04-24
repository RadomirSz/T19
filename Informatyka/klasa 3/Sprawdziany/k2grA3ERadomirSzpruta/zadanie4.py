#Napisz program zadanie4.py, wyświetlający sumę dwóch liczb
# całkowitych binarnych podanych przez użytkownika jako napisy
# złożone z zer i jedynek. Wynik wyświetl w systemie binarnym.
# Nie korzystaj z funkcji wbudowanych do konwersji systemów liczbowych.


def toDec(string):
    result = 0
    power = 0
    for cyfra in reversed(string):
        result += int(cyfra) * 2 ** power
        power += 1
    return result


def fromDec(number):
    result = ""
    while number > 0:
        result = str(number % 2) + result
        number //= 2
    return result

a = input()
b = input()

decWynik = toDec(a) + toDec(b)

print(fromDec(decWynik))


