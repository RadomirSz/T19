import random

def binary_search(T, a):
    n = len(T)
    lewy = 0
    prawy = n-1
    while lewy < prawy:
        srodek = (lewy + prawy)// 2
        if T[srodek] < a:
            lewy = srodek + 1
        else:
            prawy = srodek
    return T[lewy] == a

x = random.randint(1,11)
list = [x]
for i in range(1000000):
    temp = list[i] + random.randint(1,4)
    list.append(temp)



#print(list[599900:600300])
if binary_search(list, 1500000): print("tak")
else: print("nie")