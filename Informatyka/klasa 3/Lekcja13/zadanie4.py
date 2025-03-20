# Napisz program, który wczyta z pliku liczby.txt ciąg liczb,
# a następnie wyświetli ten ciąg posortowany metodą sortowania
# szybkiego zgodnie z algorytmem opisanym na stronie:



plik = open("liczby.txt","r")
T = list(map(int,plik.read().split()))
plik.close()
print(sortowanie_szybkie(T))