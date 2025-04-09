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

prostokat2 = ProstokatEkstra(3, 4)

prostokat2.wyswietl_pole()
prostokat2.wyswietl_obwod()