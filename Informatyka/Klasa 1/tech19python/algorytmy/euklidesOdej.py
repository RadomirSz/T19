# a = int(input())
# b = int(input()) 
# while a!=b:
#   if a>b: a=a-b
#   if b>a: b=b-a
# print(a)

#zrobiłem sam, pogchamp?????
a, b = int(input()), int(input())
while b>0:
  r = a%b
  a = b
  b = r
print(a)