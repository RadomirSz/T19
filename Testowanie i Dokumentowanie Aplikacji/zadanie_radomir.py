
    #zad 7
def liczba_lustrzana(a):
    if(type(a) != int):
        return False
    if a < 0:
        c = str(a)[::-1]
        return int("-" + c[:len(c)-1])
    else:
        return int(str(a)[::-1])
#zad 15
def liczba_cyfr(a):
    if(type(a) != int):
        return False
    return len(str(a))
