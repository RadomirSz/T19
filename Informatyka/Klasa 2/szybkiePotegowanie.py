a = int(input())
n = int(input())
wynik = 1
while(n>0):
    if n%2==1:
        wynik *= a
    a *= a
    n //= 2
print(wynik)