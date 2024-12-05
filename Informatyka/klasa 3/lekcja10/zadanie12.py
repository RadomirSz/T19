plik = open("liczby.txt","r")
T = list(map(int,plik.readline().split()))
plik.close()

tempT = []
tempOut = []
for i in range(len(T)-1):
    if T[i+1] >= T[i]:
        tempT.append(T[i])
    else:
        tempT.append(T[i])
        if len(tempT) > len(tempOut):
            tempOut = tempT
        tempT = []
print(tempOut)
