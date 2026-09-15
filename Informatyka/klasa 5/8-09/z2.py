
def ispalindrome(a):
    if a == a[::-1]:
        return True
    return False
print("2.1")
plik = open("symbole.txt","r")
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





plik.close()