plik = open("nominaly.txt","r")

nominaly = list(map(int,plik.readline().split()))
plik.close()

input = int(input())
output = {}

for b in nominaly:
        ile = input // b
        if ile > 0:
            output[b] = ile
            input %= b
print(output)