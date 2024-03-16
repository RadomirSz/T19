#cezar 
kod = ""
a = input("podaj 3 litery: ")
for i in range(0, 3, 1):
  kod += chr(ord(a[i])+i*2+1)
print(kod)