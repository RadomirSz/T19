#Napisz program obliczający sumę dwóch liczb binarnych podanych przez użytkownika. 
#Wynik podaj w systemie binarnym. Możesz wykorzystać pośrednią zamianę na system dziesiętnym.

a = int(input("Podaj pierwsza liczbe binarna: "), 2)
b = int(input("Podaj druga liczbe binarna: "), 2)
suma = a + b
print("Suma liczb binarnych to: ", bin(suma)[2:])