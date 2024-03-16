using System;
//euklides x 2


/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int euklidesodej(int a, int b)
{
    while ( a!=b )
    {
        if (a > b) { a = a - b; }
        if (b > a) { b = b - a; }
    }
    return a;
}
Console.WriteLine(euklidesodej(a,b));
int euklidesmod(int a, int b)
{
    
    while (b > 0)
    {
        int r = a % b;
        a = b;
        b = r;
    }
    return a;
}
Console.WriteLine();
Console.WriteLine(euklidesmod(a,b));*/

/*
Random r = new Random();
int n = 20;
int[] T = new int[n];
for (int i = 0; i < n; i++) T[i] = r.Next(1, 100);

foreach (int i in T) System.Console.Write(i + " ");

System.Console.WriteLine();
System.Console.WriteLine();
void sortbobel(int[] T)
{
    int temp;
    for (int i = T.Length - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (T[j] > T[j + 1])
            {
                temp = T[j];
                T[j] = T[j + 1];
                T[j + 1] = temp;
            }
        }
    }
    foreach (int i in T) System.Console.Write(i + " ");
}
sortbobel(T); 
*/

// wypisz wszystkie pary liczb zaprzyjaznionych z przedzialu 1-10000

/*int sumadzielnikow(int n) 
{
    int suma=0;
    for (int i = 1; i < n/2; i++)
        if (n % i == 0) suma += i;
    return suma;
}
int temp;
for (int i = 1; i <= 10000; i++)
{
    temp = sumadzielnikow(i);
    if (sumadzielnikow(temp) == i && i != temp)
    {
        Console.WriteLine($"{i},{temp}");
    }
}*/








/*Random r = new Random();
int n = 30;
int[] T = new int[n];
for (int i = 0; i < n; i++) T[i] = r.Next(100,1000);
List<int> list = new List<int>();
foreach (var t in T)
{ 
    if(t%17==0) list.Add(t);
}
foreach (var l in list)
{
    Console.Write(l+" ");
}*/

// macierz - wypisz sumy kolejnych ramek w macierzy kwadratowej o n parzystym
/*using System.Collections;

Random r = new Random();
int n = 8;
int[,] T = new int[n,n]; 

for (int i = 0; i < n; i++) 
    for (int j = 0; j < n; j++) T[i, j] = r.Next(0, 10);


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(T[i,j]+" ");
    }
    Console.WriteLine();
}


//sposob 1
List<int> S = new List<int>();
int suma;
for (int i = 1; i <= n / 2; i++)
{
    suma = 0;
    for (int j = n/2 - i; j < n / 2 + i; j++) 
    {
        for (int k = n / 2 - i; k < n / 2 + i; k++)
        {
            suma = suma + T[j, k]; 
        }
    }
    S.Add(suma);
}

Console.WriteLine("\n");

foreach (var l in S) Console.WriteLine(l);

int[] M = S.ToArray();
for (int i = 0; i < S.Count; i++) 
{
    Console.WriteLine(M[i] - M[i-1]);
}*/

// Źle!!