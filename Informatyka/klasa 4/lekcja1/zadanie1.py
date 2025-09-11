plik = open("nominaly.txt","r")

nominaly = list(map(int,plik.readline().split()))
plik.close()

intput = int(input())
output = []
a = 0
while intput > 0:
    if(intput >= nominaly[a]):
        output.append(nominaly[a])
        intput = intput - nominaly[a]
    else:
        a+=1
print(output)