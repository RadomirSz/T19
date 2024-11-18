import random
def gra():
    rand=random.randint(0,1)
    print("orzel czy reszka")
    a =(input("twoj nick: "))
    b =(input("jego nick: "))
    print()
    print("---")
    print(a)
    print("---")
    print(b)
    print("---")
    print()
    print((a), "wybierz orzel-0 lub reszka-1")
    c=int(input("wybierz 0 lub 1: "))
    if(rand==0): print("wypadł orzel")
    if(rand==1): print("wypadła reszka")
    if(c==rand): print("wygrana:", (a))
    else: print("wygrana:", (b))


d=0

while(d==0):
    gra()
    print("grasz? 0-tak, 1-nie")
    d = int(input())