import random


class Kosc:
    Instancje = 0
    _rng = random.Random()

    def __init__(self, wartosc=None):
        self.NazwyPlikowObrazow = [f"kosc{i}.png" for i in range(0, 7)]

        if wartosc is None:
            self.LiczbaOczek = Kosc._rng.randint(1, 6)
        else:
            if 1 <= wartosc <= 6:
                self.LiczbaOczek = wartosc
            else:
                self.LiczbaOczek = 0

        self.IdentyfikatorPliku = self.LiczbaOczek
        self.Dostepna = True
        Kosc.Instancje += 1

    def Rzut(self):
        if not self.Dostepna:
            return
        self.LiczbaOczek = Kosc._rng.randint(1, 6)
        self.IdentyfikatorPliku = self.LiczbaOczek

    def Blokuj(self):
        self.Dostepna = False

    def PobierzRzutTekst(self):
        if not (1 <= self.LiczbaOczek <= 6):
            return "nie ustawiono"
        liczby_słownie = ["jeden", "dwa", "trzy", "cztery", "pięć", "sześć"]
        return liczby_słownie[self.LiczbaOczek - 1]

    def PobierzNazwePliku(self):
        if 0 <= self.IdentyfikatorPliku < len(self.NazwyPlikowObrazow):
            return self.NazwyPlikowObrazow[self.IdentyfikatorPliku]
        return ""
