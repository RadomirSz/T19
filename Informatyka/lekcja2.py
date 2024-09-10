def czy_pierwsza(n):
    for i in range(2,n):
        if(n%i==0): return False
    return True

def czy_liczba_smitha(n):
    if(czy_pierwsza(n)): return False

def suma_cyfr_liczby(n):
    suma = 0
    while(n>0):
        suma += n%10
        n = n//10
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
    print("suma jest liczbą parzystą")
else:
    print("suma nie jest liczbą parzystą")

print(f"liczba różnych dzielników pierwszych: {liczba}")