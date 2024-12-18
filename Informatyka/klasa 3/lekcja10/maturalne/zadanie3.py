plik = open("pi.txt.","r")
T = list(map(int,plik.read().split()))
plik.close()

# print("z1:")
# licznik = 0
# for i in range(len(T)-1):
#     if(T[i] == 9 and T[i+1] > 0):
#         licznik += 1
#         #print(i+1, ":", T[i],T[i+1])
# print(licznik)
#
# print("z2:")
#
# fragmenty_pi = []
# for i in range(len(T)-1):
#     if(T[i] != 0):
#         fragmenty_pi.append(str(T[i]*10 + T[i+1]))
#     else:
#         fragmenty_pi.append("0" + str(T[i+1]))
#
# fragmenty_licznik = [0]*100
#
# for i in fragmenty_pi: fragmenty_licznik[int(i)] += 1
#
# maksymalny = 0
# minimalny = 0
# for i in range(len(fragmenty_licznik)):
#     if fragmenty_licznik[i] > fragmenty_licznik[maksymalny]:
#         maksymalny = i
#     if fragmenty_licznik[i] < fragmenty_licznik[minimalny]:
#         minimalny = i
# print(minimalny, ":", fragmenty_licznik[minimalny],"\n",
#       maksymalny,":",fragmenty_licznik[maksymalny])


print("z3:")

# def czyRosnacoMalejaca(T):
#
#     srodek = T.index(max(T))
#     T1 = T[0:srodek]
#     T2 = T[srodek+1:len(T)]
#     if T[0] >= T[1] or T[4] <= T[5]: return False
#     for i in range(len(T1)-1):
#         if T1[i] >= T1[i+1]: return False
#     for i in range(len(T2) - 1):
#         if T2[i] <= T2[i + 1]: return False
#     return True
#
# rosnacoMalejace = []
#
# for i in range(0,len(T)-5):
#     temp = T[i:i+6]
#     if czyRosnacoMalejaca(temp):
#         rosnacoMalejace.append(temp)
#         temp = []
#
#
# print(rosnacoMalejace)
# print(len(rosnacoMalejace))


print("z4:")

def czyRosnacoMalejaca(T):

    srodek = T.index(max(T))
    T1 = T[0:srodek]
    T2 = T[srodek+1:len(T)]
    if T[0] >= T[1] or T[len(T)-2] <= T[len(T)-1]: return False
    for i in range(len(T1)-1):
        if T1[i] >= T1[i+1]: return False
    for i in range(len(T2) - 1):
        if T2[i] <= T2[i + 1]: return False
    return True

m = 4
tempMaks = []
tempindex = 0
for i in range(len(T)-1):
    temp = T[i:i+m]
    if(czyRosnacoMalejaca(temp)):
        while (True):
            m+=1
            temp = T[i:i + m]
            if not czyRosnacoMalejaca(temp):
                if (len(tempMaks) < len(temp)):
                    tempindex = i-1
                    tempMaks = temp
                m = 4
                break

print(tempindex, tempMaks)



m = 4
Maks = []
Index = 0
for i in range(0,len(T)-1):
    temp = T[i:i+m]
    if(czyRosnacoMalejaca(temp) or czyrosnie(temp)):
        while (True):
            m += 1
            temp = T[i:i + m]
            if czyRosnacoMalejaca(temp) or czyrosnie(temp):
                if (len(Maks) < len(temp)):
                    Index = i + 1
                    Maks = temp
            else:
                m = 4
                break

print(Index, Maks)
