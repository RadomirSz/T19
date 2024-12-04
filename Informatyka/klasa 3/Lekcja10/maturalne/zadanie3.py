plik = open("pi_przyklad.txt.","r")
T = list(map(int,plik.read().split()))
plik.close()

# print("z1:")
# licznik = 0
# for i in range(len(T)-1):
#     if(T[i] == 9 and T[i+1] > 0):
#         licznik += 1
#         #print(i+1, ":", T[i],T[i+1])
# print(licznik)

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
# print(minimalny, ":", fragmenty_licznik[minimalny],
#       maksymalny,":", fragmenty_licznik[maksymalny])


print("z3:")

def czyRosnacoMalejaca(T):
    flaga = True
    for i in range(1,len(T)):
        if T[i-1] > T[i] and flaga:
            return False
        if flaga and T[i-1] >= T[i]:
            flaga = False
        if not flaga and T[i-1] < T[i]:
            return False
    return True

rosnacoMalejace = []

for i in range(0,len(T)-6):
    temp = T[i:i+6]
    if czyRosnacoMalejaca(temp):
        rosnacoMalejace.append(temp)
        temp = []


print(rosnacoMalejace)
print(len(rosnacoMalejace))



