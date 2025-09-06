
#zad 7
"""
************
nazwa funkcji: liczba_lustrzana
opis funkcji: funkcja tworzy liczbę lustrzaną, czyli liczbę podaną czytaną od tyłu/odwróconą
parametry: parametr "a" - liczba od której chcemy otrzymać liczbę lustrzaną
zwracany typ i opis: int, zwracana jest liczba lustrzana do podanej
autor: radek
************
"""
def liczba_lustrzana(a):
    if(type(a) != int):
        return False
    if a < 0:
        c = str(a)[::-1]
        return int("-" + c[:len(c)-1])
    else:
        return int(str(a)[::-1])

#zad 15
"""
************
nazwa funkcji: liczba cyfr
opis funkcji: funkcja podaje długość liczby zliczając ilość jej cyfr
parametry: parametr "a" - liczba której chcemy otrzymać ilość cyfr
zwracany typ i opis: int, zwracana jest ilość cyfr
autor: radek
************
"""
def liczba_cyfr(a):
    if(type(a) != int):
        return False
    return len(str(a))
