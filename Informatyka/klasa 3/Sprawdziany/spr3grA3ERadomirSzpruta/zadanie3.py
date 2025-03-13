#Napisz program w języku Python, który wyświetli spójne
# podciągi o długości 4 ciągu, znajdującego się w pierwszym
# wierszu pliku liczby.txt, które mają sumę elementów większą od 1.

plik = open("liczby.txt","r")
T = list(map(int,plik.readline().split()))
plik.close()

for i in range(len(T)-3):
    if sum(T[i:i+4]) > 1:
        print(T[i:i+4])