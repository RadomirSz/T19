
#z1
n = int(input())
czy_pierwsza = [True]*(n+1)
for i in range(2,n):
    czy_pierwsza[i] = True

p = 2
while p*p <= n:
    if czy_pierwsza[p]:
        for i in range(p*p,n+1,p):
            czy_pierwsza[i] = False
    p += 1

for i in range(2,n):
    if czy_pierwsza[i]:
        print(i,end=" ")