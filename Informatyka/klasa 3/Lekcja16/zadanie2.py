class Prostokat:
    def __init__(self, dlugosc, szerokosc): 
        self.a = dlugosc  
        self.b = szerokosc  

    def pole(self):  
        return self.a * self.b

    def obwod(self):  
        return 2 * (self.a + self.b)

prostokat1 = Prostokat(2, 5)

print("Pole prostokąta o bokach", prostokat1.a, "i", prostokat1.b, "wynosi:", prostokat1.pole())
print("Obwód prostokąta o bokach", prostokat1.a, "i", prostokat1.b, "wynosi:", prostokat1.obwod())