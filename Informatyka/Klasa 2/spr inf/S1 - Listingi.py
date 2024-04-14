# metoda prostokątów - potrzeba jest funkcja oraz trzy warianty tej metody


def f(x): 
    return -x**2 + 6*x + 2

def prostokaty1(a, b, n):
    dx = (b - a) / n
    s = 0
    for i in range(n):
        s += f(a + i * dx) * dx
    return s

def prostokaty2(a, b, n):
    dx = (b - a) / n
    s = 0
    for i in range(n):
        s += f(a + dx / 2 + i * dx) * dx
    return s

def prostokaty3(a, b, n):
    dx = (b - a) / n
    s = 0
    for i in range(n):
            s += f(a + dx + i * dx) * dx
    return s



# metoda trapezów - 2 techniki

def trapezy(a,b,n):
    dx = (b-a)/n
    suma = 0
    for i in range(n):
        suma += (f(a+i*dx)+f(a+(i+1)*dx))/2*dx
    return suma

def trapezy2(a,b,n):
    dx = (b-a)/n
    suma = f(a) + f(b)
    for i in range(1,n):
        suma += 2*f(a+i*dx)
    suma *= dx/2
    return suma


# metoda bisekcji

def bisekcja(a, b, epsilon):
    while abs(b - a) > epsilon:
        c = (a + b) / 2
        if f(c) == 0:
            return c
        elif f(a) * f(c) < 0:
            b = c
        else:
            a = c
    return (a + b) / 2 

def bisekcja2(a, b, n):
    for i in range(n):
        c = (a + b) / 2
        if f(c) == 0:
            return c
        elif f(a) * f(c) < 0:
            b = c
        else:
            a = c
    return (a + b) / 2


# Algorytm Newtona - Raphsona

def pierwiastek(x, eps):
    a = x
    b = 1
    while abs(a - b) > eps:
        a = (a + b) / 2
        b = x / a
    return a

def pierwiastek2(x, n):
    a = x
    b = 1
    for i in range(n):
        a = (a + b) / 2
        b = x / a
    return a


# Wyszukiwanie lidera

def lider(T):
    ilość = 1
    lider = T[0]
    for i in range(1,len(T)):
        if ilość == 0:
            lider = T[i]
            ilość = 1
        else:
            if T[i] == lider:
                ilość += 1
            else:
                ilość -= 1
    
    ilość_liderów = 0
    if ilość == 0:
        print("brak lidera")
    else:
        for i in range(len(T)):
            if T[i] == lider:
                ilość_liderów += 1
    if ilość_liderów > len(T)//2:
        print("Jest lider", lider)


# Monte Carlo
import random
def MonteCarlo(n):
    c = 0
    for i in range(n):
        x = random.uniform(-1,1)
        y = random.uniform(-1,1)
        if x**2 + y**2 <= 1:
            c += 1
    return 4 * c / n


print(MonteCarlo(10))
print(MonteCarlo(1000))
print(MonteCarlo(10000))


