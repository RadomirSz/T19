def czy_pierwsza(n):
    for i in range(2,n):
        if(n%i==0): return False
    return True

def czy_liczba_smitha(n):
    if(czy_pierwsza(n)): return False

def suma_cyfr_liczby(r):
    suma = 0
    while(r>0):
        suma += r%10
        r = r//10
    return suma
def suma_listy(x):
    suma = 0
    for i in x:
        suma += i
    return suma

print(suma_cyfr_liczby(202))
#faktoryzacja czy coś
#zad 1 i 2 i 3 i 4
n = int(input())
suma = 0
array = []
liczba = 0
while((n<=1) == False):
    for i in range(2,n+1):
        if(n%i==0 and czy_pierwsza(i)):
            if(i not in array):
                array.append(i)
                liczba += 1
            print(i)
            suma += i
            n = n//i
            break

print(f"suma: {suma}")

if(czy_pierwsza(suma)):
    print("suma jest liczbą pierwszą")
else:
    print("suma nie jest liczbą pierwszą")

print(f"liczba różnych dzielników pierwszych: {liczba}")

#zad 5


t = int(input("daj liczbę: "))
T = t
suma2 = 0

while((t<=1) == False):
    for i in range(2,t+1):
        if(t%i==0 and czy_pierwsza(i)):
            t = t//i
            suma2 += suma_cyfr_liczby(i)
            break

if(czy_pierwsza(T) == False):
    sum = suma_cyfr_liczby(T)
    print(sum)
    print(suma2)
    if(sum == suma2):
        print("liczba ta jest liczbą smitha")









