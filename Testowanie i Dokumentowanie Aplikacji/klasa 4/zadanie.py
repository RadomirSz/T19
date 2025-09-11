def newtonraphson(a, n):
    """
    Oblicza przybliżenie pierwiastka kwadratowego liczby `a`
    metodą Newtona-Raphsona.

    Parametry:
    ----------
    a : float
        Liczba, z której chcemy obliczyć pierwiastek kwadratowy.
        Musi być większa od zera.

    n : int
        Liczba iteracji metody Newtona-Raphsona.
        Im większa liczba iteracji, tym dokładniejszy wynik.

    Zwraca:
    -------
    float
        Przybliżona wartość pierwiastka kwadratowego liczby `a`.



    """
    p = a
    b = 1
    for _ in range(n):
        p = (p + b) / 2
        b = a / p
    return b

