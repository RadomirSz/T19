class Osoba:
    def __init__(self, imie, nazwisko, wzrost, waga):
        self.imie = imie
        self.nazwisko = nazwisko
        self.wzrost = wzrost
        self.waga = waga

    def powitanie(self):
        print(f"Witaj {self.imie} {self.nazwisko}")

    def informacje(self):
        print(f"Imię i nazwisko: {self.imie} {self.nazwisko}")
        print(f"Wzrost: {self.wzrost} cm")
        print(f"Waga: {self.waga} kg")

imie = input("Podaj imię: ")
nazwisko = input("Podaj nazwisko: ")
wzrost = float(input("Podaj wzrost (w cm): "))
waga = float(input("Podaj wagę (w kg): "))

osoba = Osoba(imie, nazwisko, wzrost, waga)

osoba.powitanie()
osoba.informacje()