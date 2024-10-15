n = 10
A = [5,2,4,24,4,8]

def first_even_number(T):
    lewy = 0
    prawy = len(T)
    while lewy<prawy:
        srodek = (lewy + prawy)//2
        if T[srodek] % 2 == 0:
            prawy = srodek
        else:
            lewy = srodek+1
        # if T[srodek] %2==0 and T[srodek-1]%2==1 and srodek > 2:
        #     return T[srodek]
    return T[lewy]


print(first_even_number(A))
