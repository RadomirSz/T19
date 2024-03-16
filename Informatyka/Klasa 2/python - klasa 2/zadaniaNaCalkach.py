import math
def f(x):
    return 2*x
    #return 3 + 2*x - math.Pow(x,2)




def calka(a,b,n):
    dx = (b-a)/n
    suma = 0
    for i in range(n):
        suma += f(a + i*dx + dx/2)
#       suma += f(a + i*dx + dx)
#       suma += f(a + i*dx)
    return suma * dx
print(calka(2,16,10000))

