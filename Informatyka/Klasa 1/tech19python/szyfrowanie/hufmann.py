#kod hufmana
W="AABCCCDDDDDEFGGGHHIJJG"
E="2AB3C5DEF3G2HI2JG"

# ilosc = 1
# H=" "
# for i in range(len(W)-1):
#   if W[i] == W[i+1]:
#     ilosc+=1
#   else:
#     if ilosc > 1:
#       H+=str(ilosc)
#     H += W[i]
#     ilosc = 1
# if ilosc > 1:
#   H+=str(ilosc)
# H += W[len(W)-1]
# print(H)

O =""
for i in E:
  if i.isnumeric():
    g = int(i)
  else:
    for y in range(g):
      O += i
    g=1
print(O)
  
  