import random


def merge(t1,t2):
    i = 0
    j = 0
    lent1 = len(t1)
    lent2 = len(t2)
    out = []
    while i < lent1 and j < lent2:
        if t1[i] < t2[j]:
            out.append(t1[i])
            i+=1
        else:
            out.append(t2[j])
            j+=1
    out.extend(t1[i:])
    out.extend(t2[j:])
    return out


def mergeSort(T):
    lenT = len(T)
    if lenT > 1:
        srodek = (lenT - 1) // 2
        lewy = mergeSort(T[:srodek+1])
        prawy = mergeSort(T[srodek+1:])
        return merge(lewy,prawy)
    return T



tab = [random.randint(1,1000001) for x in range(1000000)]

sortedtab = mergeSort(tab)

plik = open("wyniki_3.txt","w")

for i in range(len(sortedtab)):
    plik.write(str(sortedtab[i]) + "\n")


plik.close()