
imie = input()
nazwisko = input()

plik = open("dane_osobowe.txt",'w')

plik.write(imie + "\n")
plik.write(nazwisko)
plik.close()