print("średnia")
a = int(input("ile ocen?"))
print()
srednia = 0
sredniaout = 0
dzielnik = 0
for _ in range(1,a+1):
    b = int(input("jaka ocena?"))
    c = int(input("jaka waga?"))
    srednia += b*c
    dzielnik += c
    sredniaout = srednia / dzielnik
    print(sredniaout)