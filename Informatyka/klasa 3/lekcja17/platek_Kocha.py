import turtle

def rysuj_krzywa_kocha(t, dlugosc, poziom):
    if poziom == 0:
        t.forward(dlugosc)
    else:
        dlugosc /= 3.0
        rysuj_krzywa_kocha(t, dlugosc, poziom - 1)
        t.left(60)
        rysuj_krzywa_kocha(t, dlugosc, poziom - 1)
        t.right(120)
        rysuj_krzywa_kocha(t, dlugosc, poziom - 1)
        t.left(60)
        rysuj_krzywa_kocha(t, dlugosc, poziom - 1)

def rysuj_platek_kocha(poziom):
    ekran = turtle.Screen()
    ekran.setup(500, 500)
    ekran.title("Płatek Kocha")
    
    t = turtle.Turtle()
    t.speed(0)  # Najszybsze rysowanie
    t.hideturtle()
    
    # Początkowe ustawienie pozycji
    t.penup()
    t.goto(-150, 100)
    t.pendown()
    
    for _ in range(3):
        rysuj_krzywa_kocha(t, 300, poziom)  # Rysowanie krzywej Kocha
        t.right(120)
    
    ekran.mainloop()

# Uruchom rysowanie płatka Kocha
rysuj_platek_kocha(poziom=3)
