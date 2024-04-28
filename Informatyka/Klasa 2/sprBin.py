def lenik(a):
    lenik = 0
    for _ in a:
        lenik += 1
    return lenik



def dec2bin(n):
    out = ""
    while(n>0):
        out = str(n%2) + out
        n //= 2
    return out

def licznikBlokow(n):
    N = dec2bin(n)
    licznik = 0
    for i in range(lenik(N)-1):
        if N[i] != N[i+1]:
            licznik += 1
    return licznik

def searchBinMax(T):
    maks = "0"
    for i in range(lenik(T)):
        if lenik(T[i]) > lenik(maks):
            maks = T[i]
        elif lenik(T[i]) == lenik(maks):
            t = T[i]
            if int(t) > int(maks):
                    maks = t
            #for j in range(lenik(t)-1):
                # if(t[j] == "1" and maks[j] == "0"): 
                #     maks = t  dlaczego to kurka nie dziala
                
    return maks
    
    
def zad1():
    n = int(input())
    print(licznikBlokow(n))
#zad1()

def zad2():
    print()
zad2()
def zad3():
    with open("C:/Users/Radomir/Desktop/T19/Informatyka/Klasa 2/bin.txt") as p:
        T = p.read().split()
        print(searchBinMax(T))
zad3()