import turtle

def draw_tree(t, branch_length, level):
    """
    Funkcja rysująca drzewo binarne rekurencyjnie od góry do dołu
    
    Parametry:
    t - obiekt żółwia (turtle)
    branch_length - długość gałęzi
    level - aktualny poziom rekurencji (stopień drzewa)
    """
    if level == 0:  # warunek zakończenia rekurencji
        return
    
    # Rysujemy gałąź
    t.forward(branch_length)
    
    # Zapisujemy aktualną pozycję i kierunek
    pos = t.position()
    heading = t.heading()
    
    # Rysujemy lewą gałąź (skręcamy w lewo)
    t.left(30)
    draw_tree(t, branch_length * 0.7, level - 1)
    
    # Wracamy do zapisanej pozycji i kierunku
    t.penup()
    t.goto(pos)
    t.setheading(heading)
    t.pendown()
    
    # Rysujemy prawą gałąź (skręcamy w prawo)
    t.right(30)
    draw_tree(t, branch_length * 0.7, level - 1)
    
    # Wracamy do punktu startowego
    t.penup()
    t.goto(pos)
    t.setheading(heading)
    t.pendown()
    
    # Cofamy się do początku gałęzi
    t.backward(branch_length)

# Ustawienia początkowe
screen = turtle.Screen()
screen.title("Drzewo Binarne")
screen.bgcolor("white")

t = turtle.Turtle()
t.speed(0)  # najszybsze rysowanie
t.pensize(2)
t.color("brown")

# Rozpoczynamy rysowanie od góry ekranu
t.penup()
t.goto(0, 250)  # początkowa pozycja - góra ekranu
t.pendown()
t.right(90)  # kierunek w dół

# Rysujemy drzewo binarne stopnia 4
draw_tree(t, 100, 4)

# Ukrywamy żółwia po zakończeniu rysowania
t.hideturtle()

# Zamykamy okno po kliknięciu
screen.exitonclick()