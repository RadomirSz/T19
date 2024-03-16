a, b = int(input()), int(input())
# x = a*b
# while b>0:
#   r = a%b
#   a = b
#   b = r
# print("NWD: " + a)
# print("NWW: " + x/a)



d = b
c = a
while a!=b:
  if a<b: 
    a = a + c
  if b<a: 
    b = b + d
print(a)


