#zadanie z tablicy
# q = int(input())
# p = int(input())
# if (q < 1.3*p):
#   print ("TAK")
# else:
#   print("NIE")

# #zad1
 # n = int(input())
 # for i in range(n):
 #   print(i**3+3, end=" ")

# print(list(range(10)))
# print(list(range(5)))
# print(list(range(2,10)))
# print(list(range(12,10)))
# print(list(range(12,10, -1)))

#print(list(range(9, 1, -2)))

# for i in range(0,10,2):
#   print(i, end=" ")

#L = [0,1,2,3,4,5,6]
#print(L[:4:-3])
#       ^^^ 
#range musi mieć podane liczby
#list nie musi
#range(start,stop,step)

#pętla liczb dwucyfrowych od 10 do 21
#for i in range(10,22): print (i, end=" ")
#pętla liczb dwucyfrowych nieparzystych od 15 do 31
#for i in range(15,32,2): print (i,end=" ")
#pętla liczb dwucyfrowych malejąco (step ujemny)
#for i in range(99,9,-1): print (i, end=" ")
#pętla liczb 3-cyfrowych podzielnych przez 20
# for i in range(100,981,20): print (i, end=" ")

#zad2
#for i in range(105,1000,15): print(i, end=" ")

# zad3
# n = int(input())
# for i in range(1,n+1):
#  if (n % i == 0) :
#    print(i, end=" ")

#zad4
# a = 0
# for i in range(10,100):a = a + i;
# print (a, end=" ")


#zad5
#ZAPAMIĘTAĆ
# n = int(input())
# suma = (n*(n+1)//2)

# for i in range(n-1):
#   x=int(input())
#   suma = suma - x
# print("nie podałeś:",suma)

# zad6
#  int n = int.Parse(Console.Readline());
# int a = 1;
# int b = 1;
# int temp;
# Console.Writeline($"{a} {b}")
# for (int i = 0; i < n - 1; i++)
# { 
# temp= a;
#     a = b;
#     b = temp + b;
#     Console.WriteLine(b+" ")
# } 