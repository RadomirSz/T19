# Sprawdzian grupa A - sortowanie przez scalanie, schemat Hornera, znajdowanie podciągów o różnych własnościach, podciągi – sumowanie

# Zadanie 1. (5 pkt)
# W pliku wielomian.txt w pierwszym wierszu znajduje się liczba całkowita oznaczająca stopień wielomianu n, w drugim
# wierszu znajduje się liczba całkowita oznaczająca argument x. W trzecim wierszu znajdują się współczynniki wielomianu
# rozdzielone spacjami w kolejności od współczynnika przy najwyższej potędze do wyrazu wolnego.
# Napisz program, który wyświetli wartość wielomianu stopnia n, dla argumentu x, o współczynnikach podanych w pliku
# wielomian.txt. Wykorzystaj schemat Hornera, aby zminimalizować liczbę wykonywanych działań mnożenia.

plik = open("wielomian.txt","r")
n = plik.readline()
x = plik.readline()
wsp = list(map(int,plik.readline().split()))
plik.close()


def Horner(n,wsp,x):
    wynik = wsp[0]
    for i in range(1, n+1):
        wynik = wynik * x + wsp[i]
    return wynik
def ReverseHorner(n,wsp,x):
    wynik = wsp[-1]
    for i in range(n-1,-1,-1):
        wynik = wynik * x + wsp[i]
    return wynik


print(Horner(n,wsp,x))



# Zadanie 2. (5 pkt)
# Napisz program w języku Python, który wczyta ciągi z pliku ciagi.txt i wyświetli te ciągi, które są rosnące.
# W pliku ciagi.txt każdy wiersz zawiera jeden ciąg liczb całkowitych rozdzielonych spacjami.
# plik2 = open("ciagi.txt","r")
# T = plik2.readlines()
# plik2.close()
# def czyrosnie(t):
#     for i in range(1,len(t)):
#         if t[i-1] >= t[i]:
#             return False
#     return True
# for t in T:
#     ciag = list(map(int,t.split()))
#     if czyrosnie(ciag):
#         print(ciag)
# Zadanie 3. (5 pkt)
# Napisz program w języku Python, który wyświetli spójne podciągi o długości 4 ciągu, znajdującego się w
# pierwszym wierszu pliku liczby.txt, które mają sumę elementów większą od 1.

# plik3 = open("liczby.txt","r")
# T = list(map(int,plik3.read().split()))
# plik3.close()
# for i in range(len(T)-3):
#     if sum(T[i:i+4])>0:
#         print(T[i:i+4])





#sortowanie
# n = len(T)
# pom = [0]*n
# def scal(tab, lewy, srodek, prawy):
#     i = lewy
#     j = srodek + 1
#     k = lewy
#     while i<=srodek and j <= prawy:
#         if tab[i] < tab[j]:
#             pom[k] = tab[i]
#             i += 1
#         else:
#             pom[k] = tab[j]
#             j += 1
#         k += 1
#     while i <= srodek:
#         pom[k] = tab[i]
#         i += 1
#         k += 1
#     while j <= prawy:
#         pom[k] = tab[j]
#         j += 1
#         k += 1
#     for i in range(lewy,prawy+1):
#         tab[i] = pom[i]
#
# def sortuj(tab, lewy, prawy):
#     if lewy < prawy:
#         srodek = (prawy+lewy) // 2
#         sortuj(tab,lewy,srodek)
#         sortuj(tab, srodek+1, prawy)
#         scal(tab,lewy,srodek,prawy)
