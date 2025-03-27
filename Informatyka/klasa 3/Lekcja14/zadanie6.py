import math

liczba = input()

czesci = liczba.split(",")
liczba = czesci[0]
if(len(czesci) == 2):
    ulamek = czesci[1]
liczba = liczba[::-1]


output = 0
for i in range(len(liczba)):
    if(liczba[i] == '1'):
        output += 2**i
print(output)

for i in range(len(ulamek)):
    if ulamek[i] == "1":
        output += 2**(-i-1)
print(output)
