def binary_search(T,lewy,prawy,a):
    if prawy >= lewy:
        srodek = (lewy + prawy)//2
        if T[srodek] == a:
            return True
        elif T[srodek] > a:
            return binary_search(T,lewy,srodek-1,a)
        elif T[srodek] < a:
            return  binary_search(T,srodek+1,prawy,a)
    else:
        return False

plik = open("ciagi.txt", "r")

plik1 = plik.readlines()
x = int(plik1[0])

for i in range(1,len(plik1)):
    lista = list(map(int,plik1[i].split()))
    if(binary_search(lista,0,len(lista)-1,x)):
        print(plik1[i].rstrip())


plik.close()
