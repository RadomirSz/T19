def wyszukiwanie_binarne(T, a):
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

def czy_niemalejace(T):
    for i in range(1,len(T)+1):
        if T[i] < T[i-1]:
            return False
    return True

lista = []
for i in range(10):
    a = int(input("podaj liczbę: "))
    lista.append(a)

szukana = int(input("szukana liczba: "))

if wyszukiwanie_binarne(lista,szukana): print("tak")
else: print("nie")