#Napisz program w języku Python, który wczyta ciągi z pliku ciagi.txt
# i wyświetli te ciągi, które są rosnące. W pliku ciagi.txt każdy wiersz
# zawiera jeden ciąg liczb całkowitych rozdzielonych spacjami.

plik = open("ciagi.txt","r")
T = plik.readlines()
plik.close()

def czyRosnie(T):
    for i in range(1,len(T)):
        if(T[i] <= T[i-1]):
            return False
    return True

for i in range(len(T)):
    ciag = list(map(int,T[i].split()))
    if czyRosnie(ciag):
        print(ciag)




