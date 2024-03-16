# champions = []
# pole = []
# tablica = []
# for i in range(14):
#   champions.append(i)
#   pole.append(i)

# for i in range(len(pole)):
#   for j in range(len(champions)):
#     tablica.append(f"{pole[i]}.{champions[j]}")
#     for i in range(14):
#       print(tablica[i])
#     if pole[i]==champions[j]:
#       print("trafiony!")
    
# # print(tablica)







# meow książka

from random import randint
T = [".",".",".",".",".","?","?","!","!"]
for i in range(100):
  print("-Meow",end=" ")
  for j in range(randint(4,16)):
    print("meow",end=" ")
  print(T[randint(0,8)])