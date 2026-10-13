
def ispalindrome(a):
    if a == a[::-1]:
        return True
    return False
print("2.1")
plik = open("symbole_przyklad.txt","r")
T = []
for linia in plik:
    linia = linia.rstrip()
    T.append(linia)
    if ispalindrome(linia):
        print(linia)

print("2.2")
ilosc_kwadratow = 0
pozycje = []
for i in range(1,len(T)-1):
    for j in range(1,len(T[i])-1):
        if T[i-1][j-1]==T[i-1][j]==T[i-1][j+1]==T[i][j-1]==T[i][j]==T[i][j+1]==T[i+1][j-1]==T[i+1][j]==T[i+1][j+1]:
            ilosc_kwadratow+=1
            pozycje.append((i+1,j+1))

print(ilosc_kwadratow)
for i in pozycje:
    print(i[0],i[1])


print("2.3")
def konwert(T):
    A = []
    for i in T:
        temp = ""
        for j in i:
            if j == "o":
                temp += "0"
            if j == "*":
                temp += "2"
            if j == "+":
                temp += "1"
        A.append(temp)
    return A

Liczby = konwert(T)

max = -1
maks = ""
for i in range(len(Liczby)):
    a = int(Liczby[i],3)
    if a>max:
        max = a
        maks = T[i]

print(max , ": ", maks)


print("2.4")


def na_trojkowy(liczba):
    if liczba == 0:
        return "0"

    trojkowy = ""
    while liczba > 0:
        reszta = liczba % 3
        trojkowy = str(reszta) + trojkowy
        liczba = liczba // 3

    temp = ""
    for i in range(len(trojkowy)):
        if trojkowy[i] == "0":
            temp += "o"
        if trojkowy[i] == "2":
            temp += "*"
        if trojkowy[i] == "1":
            temp += "+"
    return temp


suma = 0
for i in Liczby:
    suma += int(i,3)

trojkowa_suma = na_trojkowy(suma)
print(suma)
print(trojkowa_suma)


plik.close()