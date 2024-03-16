#Sx^ndx = x^(n+1) / n+1

def f(x):
    return x+3

def prostokaty(a,b,n):
    dx = (b-a)/n
    s = 0
    for i in range(n):
        s += f(a+i * dx) *dx
    return s

print(prostokaty(2,6,400000000))