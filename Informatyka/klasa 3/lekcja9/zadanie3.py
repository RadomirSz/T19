def HornerReku(A, n, x):
    if n == 0: return A[0]
    return x * HornerReku(A[1:], n - 1, x) + A[0]

wspolczynniki = list(map(int, input("Podaj wspolczynniki od a0 d0 an: ").split()))
n = len(wspolczynniki) - 1
x = float(input("Podaj x: "))
print(HornerReku(wspolczynniki, n, x))