# s = input()
#napis (string) to jakby "lista", więc działa i for z range
# for x in s:
#   print(x)

# for i in range(len(s)):
#   print(s[i])

#for szybszy od foreacha
#napis tonie jest lista sensu stricte
#L=[4,5,6,1]
#L.sort()
#s.sort() # BŁĄD!!!!! - napis to nie jest "pełna" lista
#print(s, L)

#przechodzenie z listy na napis i z napisu w liste

# L = list(s)
# print(L)
# L.sort()
# print(L)

# w = "".join(L)
# print(w)
# x = "-".join(L)
# print(x)

# # for i in range(len(s)-1):
# #   if s[i] == s[len(s)-i]:
# #     print('jest')
# #   else:
# #     print("nie")

# d = list(s)
# c = list(s)
# c.reverse()

# if c == d:
#   print("jest policoś")
# else:
#   print("nie jes")


#sprawdzenie palindroma za pomocą listy
# for i in range(len(s)//2):
#   if s[i]==s[len(s)-1-i]:
#     exit("niejest")

# exit("jest")

#L[start:stop:step]
L = [ i for i in range(1,10)]
print(L)
print(L[:4])
print(L[::2])
print(L[1::2])
print(L[::-1])
print(L[1:6:2])
print(L[1:6:-2])# źleeeeeeeeeee
print(L[6:1:-2])