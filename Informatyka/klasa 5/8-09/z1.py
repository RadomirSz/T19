def przestaw2(n):
    mnoznik = 1
    wynik = 0
    while n > 9:
        para = n%100
        n = n // 100
        cyfra_jednosci = para % 10
        cyfra_dziesiatek = para // 10
        odwrocona = 10*cyfra_jednosci + cyfra_dziesiatek
        wynik = wynik + odwrocona * mnoznik
        mnoznik = mnoznik * 100
    if n>0:
        wynik = wynik + n * mnoznik
    return wynik

print(przestaw2(100240))