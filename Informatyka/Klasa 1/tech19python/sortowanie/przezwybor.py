#losowa lista 7 elementów [1;20]
from random import randint
n=100
T=[randint(1,1000) for i in range(n)]
print(T)

for i in range(n):
  mi = i
  for j in range(i+1,n):
    if T[j]<T[mi]:
      mi = j
  #T[i] <-> T[mi]
  T[i],T[mi] = T[mi],T[i]
print(T)
#bąbelkowe
#wybór
#kubełkowe 
#match 
#scalanie       
#quicksort


