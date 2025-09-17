wartosc = {'I':1, 'V':5, 'X':10, 'L':50, 'C':100, 'D':500, 'M':1000}

rzymska = input("Podaj liczbę rzymską: ")

wynik = 0
i = 0
dlugoscPodanej = len(rzymska)

while i < dlugoscPodanej:
    if i+1 < dlugoscPodanej and wartosc[rzymska[i]] < wartosc[rzymska[i+1]]:
        wynik += wartosc[rzymska[i+1]] - wartosc[rzymska[i]]
        i += 2
    else:
        wynik += wartosc[rzymska[i]]
        i += 1

print(wynik)
