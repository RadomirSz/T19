# ZAGADNIENIA Napisy 
# - len, for, "foreach", ord, chr
# - indeksy, zakresy
# - konwersje list <-> napis
# - list - sort reverse
# - split, join
# Algorytmy - anagram, palindom, Boyer-Moore

# Wszystkie zadania wykonujemy na 26-znakowym
# alfabecie maturalnym: od A (65) do Z (90)
# ABCDEFGHIJKLMNOPQRSTUVWXYZ

# Przykładowe zadania:

# 1. Wczytaj dowolny napis i wypisz z niego pierwszą i ostatnią literkę
i = input()
print(f"ostatnia: {i[len(i)-1]}")
print(f"pierwsza:{i[0]}")
  
# 2. Wczytaj dowolny napis i wypisz z niego literki bez pierwszej i ostatniej
for a in range(1,len(i)-1):
  print(i[a])
  
# 3. Wypisz 4 ostatnie literki z wpisanego napisy w kolejności od końca
I = list(i)
I.reverse();
i = "".join(I)
print(I[:4])



#coś tu nei działa!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
# print(i[-1:-5:-1])
# print(i[:-5:-1])
# # for g in range(len(i)-1,len(i)-5,-1):
# #   print(i[g])

# for b in range(4):
#   print(i[len(i)-b-1])
#!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
# 4. Waga napisu to suma kodów ascii jego liter. Zważ wpisny napis
waga = 0
for j in range(len(i)):
  waga+=ord(i[j])
print(f"waga:{waga}")
# 5. Policz ile we wpisanym napisie jest liter A.
ilosc=0
for k in range(len(i)):
  if ord(i[k]) == 65:
    ilosc+=1
print(ilosc)
ilosć=0
for h in i:
  if h == "A":
    ilosć+=1
print(ilosć)

# 6. Podaj dominującą literkę we wpisanym napisie. 
# Niech to będzie tylko jedna literka.

# 7. Znajdź literkę-dominantę w napisie (może ich być kilka, a może nie być żadnej)

# 8. Sprawdź czy w napisie występują trzy podciągi "LA"

# 9. Znajdź "średnią literkę" w napisie. (Przejdź na kody ASCII i jeśli wynik będzie
# ułamkowy to zaokrąglij średnią w dół)

# 10. Wypisz literki, których nie ma w napisie

# 11. Znajdź ilość trzyznakowych palindromów w napisie (trzy literki koło siebie)