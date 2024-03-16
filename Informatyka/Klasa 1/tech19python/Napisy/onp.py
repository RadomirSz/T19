#ciekawe
#fifo / lifo
#priorytety!
#() = 0
#- + = 1
#* / = 2
#^ = 3

# ciag = input()
# wynik = 0
# stos = []
# for i in range(len(ciag)-1):
#   if isdigit(ciag[i]):
#     wynik.append(ciag[i])
#   else:
#     stos.append(ciag[i])



#obliczanie onp
s = input()
stos = []
for elem in s:
  if elem.isdigit():
    stos.append(int(elem))
  else:
    b,a = stos.pop(),stos.pop()
    if elem == "+": stos.append(a+b)
    elif elem =="*": stos.append(a*b)
    elif elem =="-": stos.append(a-b)
    elif elem =="/": stos.append(a//b)
  print(stos) 
print(stos)

#783245++-327**+-+ np
