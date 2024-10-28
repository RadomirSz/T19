# Napisz program (każdy podpunkt jako osobny program), który odczyta plik slowa.txt, a następnie:
# a wyświetli ponumerowane słowa z pliku tekstowego
# b wyświetli liczbę słów w pliku
# c wyświetli słowa zaczynające się na literę A
# d wyświetli słowa kończące się na literę A
# e wyświetli słowa oraz liczbę liter, z których się składają
# f *wyświetli najkrótsze oraz najdłuższe słowo w pliku oraz ich długość (jeżeli jest ich kilka wyświetl pierwsze z nich)
# g wyświetli słowa o długości 6
# h wyświetli słowa zawierające literę O oraz dla każdego z tych słów liczbę tych liter O
# i wyświetli ile razy w całym pliku występuje litera A


plik = open("C:\\Users\\Radomir\\Desktop\\T19\\Informatyka\\klasa 3\\lekcja7\\slowa.txt", "r")

plik1 = list(map(str,plik.read().split()))
plik.close()

print("a)")
for i in range(len(plik1)):
    print(i+1, plik1[i])

print("b)")
print(len(plik1))


print("c)")

for i in range(len(plik1)):
    if(plik1[i][0] == "A"):
        print(plik1[i])

print("d)")

for i in range(len(plik1)):
    if(plik1[i][len(plik1[i])-1] == "A"):
        print(plik1[i])

print("e)")

for i in range(len(plik1)):
    print(plik1[i], len(plik1[i]))

print("f)")

najdluzsze = ""
najkrotsze = plik1[0]
for i in range(len(plik1)):
    dlugosc = len(plik1[i])
    if dlugosc > len(najdluzsze):
        najdluzsze = plik1[i]
    if dlugosc < len(najkrotsze):
        najkrotsze = plik1[i]
print(najkrotsze, najdluzsze)

print("g)")

for i in range(len(plik1)):
    if len(plik1[i])== 6: print(plik1[i])

print("h)")

for i in range(len(plik1)):
    if plik1[i].count("O") > 0:
        print(plik1[i], plik1[i].count("O"))

print("i)")

suma = 0
for i in range(len(plik1)):
    suma += plik1[i].count("A")
print(suma)