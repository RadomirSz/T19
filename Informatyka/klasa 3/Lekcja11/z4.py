plik = open("liczby.txt", "r")
T = list(map(int, plik.readline().split()))

plik.close()
maxLen = -1
tempLen = 1
for i in range(1,len(T)):

    if T[i-1] <= T[i]:
        tempLen += 1
    else:
        if tempLen > maxLen:
            maxLen = tempLen
        tempLen = 1
        i = i + tempLen
if tempLen > maxLen:
    maxLen = tempLen
print(maxLen)