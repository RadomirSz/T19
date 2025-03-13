# W pliku wielomian.txt w pierwszym wierszu znajduje się liczba
# całkowita oznaczająca stopień wielomianu n, w drugim wierszu
# znajduje się liczba całkowita oznaczająca argument x.
# W trzecim wierszu znajdują się współczynniki wielomianu
# rozdzielone spacjami w kolejności od współczynnika przy
# najwyższej potędze do wyrazu wolnego. Napisz program, który
# wyświetli wartość wielomianu stopnia n, dla argumentu x, o
# współczynnikach podanych w pliku wielomian.txt. Wykorzystaj
# schemat Hornera, aby zminimalizować liczbę wykonywanych działań mnożenia.


plik = open("wielomian.txt","r")
n = int(plik.readline())
x = int(plik.readline())
wsp = list(map(int,plik.readline().split()))
plik.close()

def Horner(n,wsp,x):
    result = wsp[0]
    for i in range(1,n+1):
        result = x * result + wsp[i]
    return result

print(Horner(n,wsp,x))