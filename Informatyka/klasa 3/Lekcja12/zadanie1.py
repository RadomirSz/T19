from random import randint
max,min = -1,1001
T = [0]*100
for i in range(100):
    n = randint(1, 1000)
    T[i] = n
    if n<min: min = n
    if n>max: max = n
print(T)
print(min,max)

#200 porównań

