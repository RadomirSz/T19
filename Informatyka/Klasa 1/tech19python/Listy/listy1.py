# x = list(range(5))
# for item in (x):
#   print(item)

# for item2 in range(4):
#     print(item2)
# print(len(x))
# for i in range(len(x)):
#   print(x[i])

#deklaracja i iteracja

# L = [3,5,8,17,27]

# for elem in L:
#   print(elem)

# for i in range(len(L)):
#   print(L[i], end=" ")

K = [4, 7, 5, 7, 3, 3, 2, 8, 7]
# print(K)

# K.append(3)
# print(K)

# print(K.count(7))

# print(K.index(7))

# K.insert(2, 4)
# print(K)

# K.insert(len(K), 4)
# print(K)

# K.pop(0)  #usuwa pierwszą
# K.pop()  #usuwa ostatnią
# print(K)

# K.reverse()
# print(K)

# K.sort()
# print(K)

# K.sort(reverse=True)  #sortuje malejąco
# print(K)


#usuwanie 7-ek
print(K)
print(K.index(7))

for i in range(K.count(7)):
  K.remove(7)
print(K)

for i in range(K.count(7)):
  K.pop(K.index(7))
print(K)


#max
o = 0
for i in range(len(K)):
  if K[i] > o: o = K[i]
print(o)


#wygeneruj listę 20 losowych liczb z przedziału (1,20)
#pendriv corsair voyager 32GB

from random import randint

L = [randint(1,20) for i in range(20)]
print(L)
print(max(L))
#ile razy występuje wartość min 
print(L.count(min(L)))

#vice - max

