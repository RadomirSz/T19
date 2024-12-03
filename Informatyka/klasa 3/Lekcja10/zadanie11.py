plik = open("liczby.txt","r")
T = list(map(int,plik.readline().split()))
plik.close()

tempLen = 0
maksLen = 0
for i in range(len(T)-1):
    if T[i+1] >= T[i]:
        tempLen +=1
    else:
        tempLen += 1
        if tempLen > maksLen:
            maksLen = tempLen
        tempLen = 0
print(maksLen)