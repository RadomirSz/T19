#binary search

def binary_search(T,a):
    n = len(T)
    lewy = 0
    prawy = n-1
    while(prawy > lewy):
        srodek = (prawy+lewy)//2
        if(T[srodek] < a):
            lewy = srodek +1
        else:
            prawy = srodek
    return T[srodek] == a


abc = [1,2,3,4,5,6,7]
print(binary_search(abc,5))

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

#sito eratostenesa

a = 100

pierwsze = [False] * (a + 1)

for i in range(2,a):
    pierwsze[i] = True

p = 2

while p*p <= a:
    if pierwsze[p]:
        for i in range(p*p, a+1,p):
            pierwsze[p]  = False
    p+=1

for i in range(2,a):
    if pierwsze[i]:
        print(i,end=" ")

#pliki i napisy

plik = open("sciezka", "r") # r - czyta, w - pisze, a - dopisuje, r+ - tryb odczytu i zapisu

plik1 = list(map(int, plik.read().split()))


plik.close()


#strip rstrip lstrip - usuwa znaki białe po prawej i po lewej, r - po prawej, l - po lewej

#Funkcja readlines() zwraca listę zawierającą wszystkie linie pliku tekstowego.
#Fragment kodu plik.read() odczytuje cały plik jako jeden napis.



#dictionary .items() 