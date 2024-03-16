#pip install numpy
#pip install matplotlib


import numpy as np
from matplotlib import pyplot


x = np.linspace(0,16)

def f(x):
    return np.sqrt(x)+2

pyplot.plot(x,f(x),color="blue")

pyplot.show()

def calka(a,b,n):
    dx = (b-a)/n
    suma = 0
    for i in range(n):
        suma += f(a + i*dx + dx/2)
#       suma += f(a + i*dx + dx)
#       suma += f(a + i*dx)
    return suma * dx
print(calka(0,16,100000))