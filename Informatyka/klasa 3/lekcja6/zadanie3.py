def binary_search(T, a):
    n = len(T)
    lewy = 0
    prawy = n-1
    while lewy < prawy:
        srodek = (lewy + prawy)// 2
        if T[srodek] < a:
            lewy = srodek + 1
        else:
            prawy = srodek
    return T[lewy] == a

sciezka = "C:\\Users\\Radomir\\Desktop\\T19\\Informatyka\\klasa 3\\lekcja6\\ciagi.txt"
plik = open(sciezka, 'r')
liczby = []
for line in plik:
    liczby.append(list(map(int, line.split())))
plik.close()

for i in liczby:
    if binary_search(i, 10):
        print(i)