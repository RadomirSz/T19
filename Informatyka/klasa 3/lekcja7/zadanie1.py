
imie = input()
nazwisko = input()

plik = open("dane_osobowe.txt",'x')

plik.write(imie + "\n")
plik.write(nazwisko)
plik.close()