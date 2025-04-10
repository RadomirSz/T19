import tkinter as tk

# Funkcja rysująca zbiór Cantora
def rysuj_cantora(x, y, dlugosc, stopien):
    if stopien == 0:
        # Rysowanie linii, jeśli doszliśmy do najgłębszego poziomu
        canvas.create_line(x, y, x+dlugosc, y, width=2)
    else:
        # Rysujemy dwie części, pomijając środkową
        rysuj_cantora(x, y, dlugosc/3, stopien-1)
        rysuj_cantora(x+2*dlugosc/3, y, dlugosc/3, stopien-1)

# Ustawienia okna
root = tk.Tk()
root.title("Zbiór Cantora")

# Ustawienia płótna
canvas = tk.Canvas(root, width=600, height=400)
canvas.pack()

# Wywołanie funkcji rysującej
rysuj_cantora(50, 50, 500, 0) # zbiór Cantora stopnia 0
rysuj_cantora(50, 150, 500, 1) # zbiór Cantora stopnia 1
rysuj_cantora(50, 250, 500, 2) # zbiór Cantora stopnia 2
rysuj_cantora(50, 350, 500, 3) # zbiór Cantora stopnia 3

# Uruchomienie pętli aplikacji
root.mainloop()
