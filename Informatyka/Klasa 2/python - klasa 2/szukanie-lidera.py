
T = [2,5,5,3,5,1,5]

def lider():
    licznik = 1
    kandydat = T[0]
    for i in range(1,len(T)):
        if licznik == 0:
            kandydat = T[i]
            licznik = 1   
        else:
            if T[i] == kandydat: licznik += 1
            else: licznik -=1

    ilość_kandydatów = 0
    if licznik == 0:
        print("brak lidera")
    else:
        for i in range(len(T)):
            if T[i] == kandydat:
                ilość_kandydatów += 1
    if ilość_kandydatów > len(T)//2:
        print("Jest lider", kandydat)
lider()