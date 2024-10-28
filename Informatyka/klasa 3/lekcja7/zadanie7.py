from random import randint

# 7. Napisz program, który:
# a. zapisze w pliku losowe_w_linii.txt 20 liczb losowych z zakresu od 1 do 10 w jednej linii rozdzielone
# spacją (po ostatniej liczbie powinien być znak nowej linii).
# b. wyświetli liczby, które występują najczęściej

plik = open("losowe_w_linii.txt","w")

amount = {}

for i in range(1,21):
    liczba = randint(1,11)
    if(liczba in amount):
        amount[liczba] += 1
    else:
        amount.update({liczba : 1})
    if(i==20): plik.write(str(liczba) + "\n")
    else: plik.write(str(liczba) + " ")
    # print(liczba)

# print(amount)
biggest = {}
maxkey = 0
maxvalue = 0
for i,j in amount.items():
    if j > maxvalue:
        biggest.clear()
        biggest.update({i : j})
        maxkey , maxvalue = i , j
    elif j == maxvalue:
        biggest.update({i : j})


print("Liczby te wystąpiły najczęściej, czyli" , maxvalue , "razy", end=": ")
for i in biggest.keys():
    print(i, end=" ")
plik.close()
