def newtonrapson(a,n):
    p = a
    b = 1
    for _ in range(n):
        p = (p+b) / 2
        b = a/p
    return p

print(newtonrapson(16,8))