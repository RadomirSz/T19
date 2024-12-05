plik = open("pi.txt.","r")
T = list(map(int,plik.read().split()))
plik.close()

print("z1:")
licznik = 0
for i in range(len(T)-1):
    if(T[i] == 9 and T[i+1] > 0):
        licznik += 1
        #print(i+1, ":", T[i],T[i+1])
print(licznik)

print("z2:")

fragmenty_pi = []
for i in range(len(T)-1):
    if(T[i] != 0):
        fragmenty_pi.append(str(T[i]*10 + T[i+1]))
    else:
        fragmenty_pi.append("0" + str(T[i+1]))

fragmenty_licznik = [0]*100

for i in fragmenty_pi: fragmenty_licznik[int(i)] += 1

maksymalny = 0
minimalny = 0
for i in range(len(fragmenty_licznik)):
    if fragmenty_licznik[i] > fragmenty_licznik[maksymalny]:
        maksymalny = i
    if fragmenty_licznik[i] < fragmenty_licznik[minimalny]:
        minimalny = i
print(minimalny, ":", fragmenty_licznik[minimalny],
      maksymalny,":", fragmenty_licznik[maksymalny])


print("z3:")

# def isValid(T):
#     if len(T) < 4:
#         return False
#
#
#     rosnie = True
#     if T[0] > T[1]:
#         rosnie = False
#
#     for i in range(1,len(T)):
#         if rosnie and T[i] > T[i-1] or not rosnie and T[i] < T[i-1]:
#             continue
#         if i == len(T):
#             return True
#
#     for i in range(len(T)-1):
#         if (rosnie and T[i] > T[i+1]) or (not rosnie and T[i] < T[i+1]):
#             return False
#
#     return True


flagaNaStart = False
flagaWSrodku = False
rosnacoMalejace = []
temp = []
for i in range(len(T)-1):
    if not flagaNaStart and T[i] < T[i+1]:
        flagaNaStart = True
        temp = []
        flagaWSrodku = True

    if flagaNaStart:
        if flagaWSrodku:
            if T[i] <= T[i+1]:
                temp.append(T[i])
            else:
                flagaWSrodku = False
        else:
            if T[i] > T[i+1]:
                temp.append(T[i])
            else:
                flagaNaStart = False
                if len(temp) > 3:
                    rosnacoMalejace.append(temp)
print(rosnacoMalejace)


def rosnie(T):
    for i in range(len(T)-1):
        if(T[i] > T[i+1]):
            return False
    return True

def maleje(T):
    for i in range(len(T)-1):
        if(T[i] < T[i+1]):
            return False
    return True

def isValid(T):
    if len(T) < 4:
        return False

    indeks = 0
    for i in range(len(T)-1):
        if T[i] >= T[i+1]:
            indeks = i
            break

    if not rosnie(T[:indeks]) or not maleje(T[indeks:]):
        return False
    else:
        return True
