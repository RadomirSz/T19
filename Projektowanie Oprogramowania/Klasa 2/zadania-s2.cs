using System.Collections;

/*1.Wpisz do tablicy T 5 losowych liczb dwucyfrowych. 
Stwórz tablicę W liczb parzystych znajdujących się między 
minimalną i maksymalną wartością z tablicy T.
*/

/*int[] T = new int[5];
Random r = new Random();
for (int i = 0; i < 5; i++)
{
    T[i] = r.Next(10,100);
}
Console.WriteLine("pierwsza");
foreach (var item in T)
{
    Console.WriteLine(item);
}
int w = (T.Max() - T.Min()) / 2;
int[] W = new int[w];

for (int i = 0; i < w; i++)
{
    if(T.Min()%2 == 0) W[i] = T.Min() + (2 * i);
    else W[i] = T.Min() + (2 * i) + 1;
}
Console.WriteLine("druga");
foreach (var item in W)
{
    Console.WriteLine(item);
}*/



// wersja 2 - od Pana Profesora Bartosza



/*int[] T2 = new int[5];

for (int i = 0; i < 5; i++)
{
    T2[i] = r.Next(10, 100);
    Console.WriteLine(T2[i]);
}
Console.WriteLine("druga");
int d = (T2.Max() - T2.Min()) / 2;
int[] D = new int[d];
int y = 0;
for (int i = T2.Min() + 1; i < T2.Max(); i++)
{
    if (i % 2 == 0)
    {
        D[y] = i;
        y++;
    }
}
foreach (var item in D)
{
    Console.WriteLine(item);
}*/



//2. Utwórz ArrayListę A zawierającą 10 losowych słów 3-literowych. 
//Wypisz słowo o najwiekszej sumie kodów ASCII jego liter



/*Random r = new Random();
ArrayList A = new ArrayList();
ArrayList A2 = new ArrayList();
int big = 0;
string biG = "";
for (int i = 0; i < 10; i++)
{
    int suma = 0;
    string a = "";
    for (int j = 0; j < 3; j++)
    {
        int x = r.Next(65, 90);
        suma += x;
        a += (char)x;
    }
    A.Add(a);
    A2.Add(suma);
    if (suma > big){ big = suma; biG = a; }
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(A[i] + ": " + A2[i]);
}
Console.WriteLine();
Console.WriteLine($"Napis z największą sumą: {biG} jego suma ascii: {big}");*/


//3. Stwórz listę L składającą się z 10 list 10 losowych cyfr. Oblicz sumę największych cyfr w listach listy L oraz 


//sprawdź czy istnieje taka lista gdzie wylosowano 3 identyczne cyfry.
/*Random r = new Random();
List<List<int>> list = new List<List<int>>();
for (int i = 0; i < 10; i++)
{
    List<int> temp = new List<int>();
    for (int j = 0; j < 10; j++)
    {
        int b = r.Next(0, 10);
        temp.Add(b);
        Console.Write(b + ",");
    }
    Console.WriteLine();
    list.Add(temp);
}
int[] sumy = new int[10];
int g = 0;
foreach (var item in list)
{
    int suma = 0;
    foreach (var item1 in item)
    {
        if (item1 == item.Max())
        {
            suma += item1;
        }
    }
    sumy[g] = suma;
    Console.WriteLine(suma);
    g++;
}*/


//4. Stwórz słownik D z kluczami i = 1, 2, 3 ... n (user podaje n) 
//oraz wartościami w postaci listy maksymalnie (i-1)-cyfrowych dzielników 
//liczby 10 do potęgi i dla każdego z kluczy.


Dictionary<int , List<int>> D =  new Dictionary<int , List<int>>();
int n = int.Parse(Console.ReadLine());
List<int> TL;
for (int i = 1; i <= n; i++)
{
    TL = new();
    for (int j = 0; j < Math.Pow(10,i-1); j++)
    {
        if (Math.Pow(10, i) % j == 0)
        {
            TL.Add(j);
        }
    }
    D.Add(i, TL);
}

foreach (var item in D)
{
    Console.Write(item.Key + " =>");
    foreach (var item1 in item.Value)
        Console.Write(item1 + " ");
    Console.WriteLine();
}