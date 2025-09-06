'''
************
nazwa funkcji: Algorytm Euklides
opis funkcji: funkcja znajduje największy wspólny dzielnik poprzez algorytm euklidesa
parametry: parametr "a" - pierwsza liczba do porównania, parametr "b" - druga liczba do porównania
zwracany typ i opis: int, zwracany jest największy wspólny dzielnik
autor: xyz
************
'''

a = int(input())
b = int(input())
def euklides(a,b):
    while(a!=b):
        if a>b:
            a=a-b
        else:
            b=b-a
    return a

print(euklides(a,b))