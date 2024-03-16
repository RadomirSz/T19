# funkcja ord() - zwraca kod ascii dla danego znaku
#print(ord('A'))
#print(ord('B'))
#funkcja chr() - zwraca znak dla danego kodu ascii
#print(chr(69))
#print(chr(81))
#można łączyć
#print(chr(ord('a')+3))

#napisz alfabet z pomocą for

# for i in range(65,91):
#   print(chr(i), end="")

#jak wydobyć literki z napisu / napis to taka tabela zawsze
napis = input()
#print(len(napis))
for i in range(0, len(napis)):
  print(napis[i])

# for i in range(0, len(napis)):
#   print(ord(napis[i]))
szyfr=""
for i in range(len(napis)):
  szyfr = szyfr + chr(65 + (ord(napis[i])- 65 + 3)%26)
print(napis, szyfr)

napis= input()
for i in range(len(napis))