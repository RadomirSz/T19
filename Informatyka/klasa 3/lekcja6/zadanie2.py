def wyszukiwanie_binarne_reku(T, a):
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
def bin_search_recu(T,lewy,prawy,a):
    srodek = (lewy+prawy)//2
    if T[srodek] < a: bin_search_recu(T,srodek+1,prawy,a)
    else: bin_search_recu(T,lewy,srodek,a)

def binary_search(arr, low, high, x): # z neta to
	if high >= low:
		mid = (high + low) // 2
		if arr[mid] == x:
			return mid
		elif arr[mid] > x:
			return binary_search(arr, low, mid - 1, x)
		else:
			return binary_search(arr, mid + 1, high, x)
	else:
		return -1

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