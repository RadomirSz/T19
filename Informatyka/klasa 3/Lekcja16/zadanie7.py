import math

class Kolo:
    def __init__(self, promien):
        self.promien = promien

    def pole(self):
        pole = math.pi * self.promien ** 2
        print(f"Pole koła o promieniu {self.promien} wynosi: {pole:.2f}")

    def obwod(self):
        obwod = 2 * math.pi * self.promien
        print(f"Obwód koła o promieniu {self.promien} wynosi: {obwod:.2f}")


promien = float(input("Podaj promień koła: "))

kolo = Kolo(promien)

kolo.pole()
kolo.obwod()