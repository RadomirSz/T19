def binary_search(T, a):
    n = len(T)
    lewy = 0
    prawy = n-1
    while lewy < prawy:
        srodek = (lewy + prawy)// 2
        if T[srodek] < a:
            lewy = srodek + 1
        else:
            prawy = srodek
    return T[lewy] == a

plik = open("ciagi2.txt")

numberLists = []
temp = True
for linia in plik:
    if temp:
        numberLists.append(list(map(int, linia.split())))
    temp = not temp
numberLists.pop(0)
for numberList in numberLists:
    if binary_search(numberList, 10):
        print(numberList)
plik.close()