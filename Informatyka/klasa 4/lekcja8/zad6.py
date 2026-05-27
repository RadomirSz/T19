

plik = open("dane6przyklad.txt","r")

pmaksymalne = []
for line in plik:
    maks = int(max(line))
    pmaksymalne.append(maks+1)
    print(maks+1)

plik.close()