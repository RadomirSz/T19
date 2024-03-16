n = int(input("licznik: "))
b = int(input("mianownik: "))
o = int(input('licznik drugiej liczby: '))
a = int(input('mianownik drugiej liczby: '))

m = b
l = a
x = l*m
while m>0:
  r = l%m
  l = m
  m = r
print()
print(l)#nwd
print(x/l)#nww
print()

e = ((x/l) // b) * n
f = ((x/l) // a) * o

# print(n+o)
# print("--------")
# print(x/l)
print(f"{e+f}/{x/l}")

