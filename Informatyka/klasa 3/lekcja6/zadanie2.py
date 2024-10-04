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


def bin_search_recu(T, lewy, prawy, a):
	if prawy >= lewy:
		mid = (prawy + lewy) // 2
		if T[mid] == a:
			return True
		elif T[mid] > a:
			return bin_search_recu(T, lewy, mid - 1, a)
		else:
			return bin_search_recu(T, mid + 1, prawy, a)
	else:
		return False

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

if bin_search_recu(lista,1,len(lista),szukana): print("tak")
else: print("nie")