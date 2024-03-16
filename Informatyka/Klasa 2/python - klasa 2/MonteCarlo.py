import random
import math

#moja próba po poprawkach
# licznik = 0
# iloscpkt = int(input())
# for _ in range(iloscpkt):
#     x = random.uniform(0,200)
#     y = random.uniform(0,200)
#     if math.sqrt((x-100)*(x-100)+(y-100)*(y-100)) <= 100:
#         licznik+=1

# wynik = (licznik / iloscpkt) * 4
# print(wynik)

def montecarlo(n):
    licznik = 0
    for _ in range(n):
        x = random.uniform(-1,1)
        y = random.uniform(-1,1)
        if x**2 + y**2 <= 1:
            licznik +=1
    return 4*licznik/n

print(montecarlo(10000000))
