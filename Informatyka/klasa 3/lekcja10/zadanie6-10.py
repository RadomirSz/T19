def f6():
    ciag = list(map(int,input().split()))

    for i in range(1,len(ciag)):
        if ciag[i] <= ciag[i-1]: return "nie"
    return "tak"

print(f6())

def f7():
    ciag = list(map(int,input().split()))

    for i in range(1,len(ciag)):
        if ciag[i] >= ciag[i-1]: return "nie"
    return "tak"

print(f7())

def f8():
    ciag = list(map(int,input().split()))

    for i in range(1,len(ciag)):
        if ciag[i] > ciag[i-1]: return "nie"
    return "tak"

print(f8())

def f9():
    ciag = list(map(int,input().split()))

    for i in range(1,len(ciag)):
        if ciag[i] < ciag[i-1]: return "nie"
    return "tak"

print(f9())

def f10():
    ciag = list(map(int,input().split()))

    for i in range(1,len(ciag)):
        if ciag[i] != ciag[i-1]: return "nie"
    return "tak"

print(f10())