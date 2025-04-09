class Prostokat:
    def __init__(self, dlugosc, szerokosc): 
        self.a = dlugosc  
        self.b = szerokosc  

    def pole(self):  
        return self.a * self.b

    def obwod(self):  
        return 2 * (self.a + self.b)

class ProstokatEkstra(Prostokat):
    def wyswietl_pole(self):
        print(f"Pole prostokąta o bokach {self.a} i {self.b} wynosi: {self.pole()}")

    def wyswietl_obwod(self):
        print(f"Obwód prostokąta o bokach {self.a} i {self.b} wynosi: {self.obwod()}")

dlugosc = float(input("Podaj długość prostokąta: "))
szerokosc = float(input("Podaj szerokość prostokąta: "))

prostokat2 = ProstokatEkstra(dlugosc, szerokosc)

prostokat2.wyswietl_pole()
prostokat2.wyswietl_obwod()