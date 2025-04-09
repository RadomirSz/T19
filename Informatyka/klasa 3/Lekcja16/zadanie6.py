class Trojkat:
    def __init__(self, a, b, c, wysokosc):
        self.a = a
        self.b = b
        self.c = c
        self.wysokosc = wysokosc

    def pole(self):
        pole = (self.a * self.wysokosc) / 2
        print(f"Pole trójkąta wynosi: {pole}")

    def obwod(self):
        obwod = self.a + self.b + self.c
        print(f"Obwód trójkąta wynosi: {obwod}")

a = float(input("Podaj długość boku a: "))
b = float(input("Podaj długość boku b: "))
c = float(input("Podaj długość boku c: "))
wysokosc = float(input("Podaj wysokość trójkąta opuszczoną na bok a: "))

trojkat = Trojkat(a, b, c, wysokosc)

trojkat.pole()
trojkat.obwod()