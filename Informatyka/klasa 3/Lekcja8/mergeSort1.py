

ciag = input("daj liczby po spacji")

liczby = list(map(int,ciag.split(" ")))
n = len(liczby)

help_list = [0] * len(n)

def merge(T, lewy, srodek, prawy, help_list):
    i = lewy
    j = srodek + 1
    k = lewy
    while i <= srodek and j <= prawy:
        if T[i] < T[j]:
            help_list[k] = T[i]
            i += 1
        else:
            help_list[k] = T[j]
            j += 1
        k += 1
    while i <= srodek:
        help_list[k] = T[i]
        i += 1
        k += 1
    while j <= prawy:
        help_list[k] = T[j]
        j += 1
        k += 1
    for i in range(lewy, prawy + 1):
        T[i] = help_list[i]


def sort(T, lewy, prawy):
    if lewy < prawy:
        srodek = (lewy + prawy) // 2
        sort(T, lewy, srodek)
        sort(T, srodek + 1, prawy)
        merge(T, lewy, srodek, prawy, help_list)