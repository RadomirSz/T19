D = {}

n, m = map(int, input().split())

for i in range(n):
    D[i+1] = []
    # D.update({ i+1 : [] })

for _ in range(m):
    p, q = map(int, input().split())
    D[p].append(q)
    D[q].append(p)
print(D)

# for i in range(1,n+1):
#     if len(D[i]) == 0:
#         print("Wiewiór sam")
#     else:
#         D[i].sort()
#         for j in range(len(D[i])):
#             print(D[i][j], end=" ")
#         print()
# print()
##### policz sumę stopni wierzechołków grafu

suma = 0
for k,v in D.items():
    suma += len(v)
print(suma)

##### znajdź wierzchołek o najwyższym stopniu

maxwie = 0
for _,x in D.items():
    maxwie = max(maxwie,len(x))
print(maxwie)
##### znajdź wierzchołki samodzielne



##### Sprawdź czy uda się dojść z wierzchołka x do y





############
def dfs(n,D, odw = []):
    # if odw == None:
    #     odw = []
    # if n not in odw:
    #     odw.append(n)
    # else: return
    # for nei in D[n]:
    #     dfs(nei,D,odw)    
    # return odw
    odw.append(n)
    for nei in D[n]:
        if nei not in odw:
            dfs(nei,D,odw)
    return odw
    
    
odwiedzone = []
w = dfs(1,D,odwiedzone)
print(w)
