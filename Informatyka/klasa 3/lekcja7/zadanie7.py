from random import randint

# 7. Napisz program, który:
# a. zapisze w pliku losowe_w_linii.txt 20 liczb losowych z zakresu od 1 do 10 w jednej linii rozdzielone
# spacją (po ostatniej liczbie powinien być znak nowej linii).
# b. wyświetli liczby, które występują najczęściej

#plik = open("losowe_w_linii.txt","x")

amount = {}

for i in range(1,21):
    liczba = randint(1,11)
    if(liczba in amount):
        amount[liczba] += 1
    else:
        amount[liczba] = 1
    # if(i==20): plik.write(str(liczba))
    # else: plik.write(str(liczba) + ' ')
    print(liczba)
#plik.write("\n")

print("w dictie: ")
for i in amount:
    print(i)

#plik.close()
