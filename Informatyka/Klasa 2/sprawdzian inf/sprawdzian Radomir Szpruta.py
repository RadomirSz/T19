
def lenM(a):
    licznik = 0
    for i in a:
        licznik += 1
    return licznik

def rewerse(s):
    return s[::-1]

def bin2dec(s):
    n = rewerse(s)
    out = 0
    for i in range(lenM(s)):
        if n[i] == "1":
            out += 2**i
    return out

def czyWieksza(s1,s2): # jezeli s1 wieksza zwraca true
    if(s1[0] != "-" and s2[0] != "-"):
        if(lenM(s1) > lenM(s2)):
            return True
        elif(lenM(s1) < lenM(s2)):
            return False
        else:
            for i in range(lenM(s1)):
                if(s1[i] == "1" and s2[i]=="0"): return True
    elif(s1[0] == "-" and s2[0] != "-"):
        return False
    elif(s1[0] != "-" and s2[0] == "-"):
        return True
    else:
        if(lenM(s1) > lenM(s2)):
            return False
        elif(lenM(s1) < lenM(s2)):
            return True
        else:
            for i in range(1,lenM(s1)-1):
                if(s1[i] == "1" and s2[i]=="0"): return True
    return False

with open("C:/Users/Uczen/Desktop/sprawdzian inf/dane_systemy1.txt") as f:
    T = f.read().split()


#z1
print("zadanie 1:")
makstemp = "0"
mintemp = "0"
for i in range(1,1095,2):
    if czyWieksza(T[i],makstemp): 
        makstemp = T[i]
        continue
    if czyWieksza(mintemp,T[i]):
        mintemp = T[i]

print(makstemp)
print(mintemp)


#z2
print("zadanie 2:")
licznik = 0
for i in range(0,1095,2):
    if(bin2dec(T[i]) != 12 + i*24):
        licznik += 1
print(licznik)

#z3
print("zadanie 3:")
makstemp2 = "0"
iloscdnirekordowych = 0
makspodbicie = 0
for i in range(1,1095,2):
    if czyWieksza(T[i],makstemp2):
        if(bin2dec(T[i]) - bin2dec(makstemp2) > makspodbicie):
            makspodbicie = bin2dec(T[i]) - bin2dec(makstemp2)
            print("nowe maksymalne podbicie: " + str(makspodbicie) + ", o godzinie " + str(bin2dec(T[i-1])))
        makstemp2 = T[i]
        iloscdnirekordowych +=1
        #print("padł rekord o godzinie: " + str(bin2dec(T[i-1])))

print("dni rekordowe: " + str(iloscdnirekordowych))