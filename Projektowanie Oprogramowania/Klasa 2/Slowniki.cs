
//6.Stwórz jakiś prosty graf 1 => 2, 3 ; 2 => 3; 3 => 2, 5; 4 => null; 5 => 3 używając Dictionary


// muj kot
/*
Dictionary<int, List<int>> graf =  new Dictionary<int, List<int>>();

bool powtorz = true;
do
{
    Console.WriteLine("podaj numer wierzcholka");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("podaj listę wierzcholkow z ktorymi sie laczy (po przecinku)");
    
    string[] y = Console.ReadLine().Split(",");
    List<string> list = y.ToList();
    List<int> list2 = list.ConvertAll<int>(Convert.ToInt32);

    graf.Add(x,list2);
    
    Console.WriteLine("dodac kolejny wierzchol? (0 - nie , 1 - tak)");
    string p = Console.ReadLine(); if (p == "0") powtorz = false;
    Console.Clear();
}while(powtorz);


foreach (var jtem in graf)
{
    Console.Write(jtem.Key + " - ");
    foreach (var item in graf[jtem.Key])
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
*/

//kot inny
Dictionary<int, List<int>> G = new();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    G.Add(i + 1, new List<int>());
}

int k = int.Parse(Console.ReadLine());

string[] liczby = new string[2];
for (int i = 0; i < k; i++)
{
    liczby = Console.ReadLine().Split();
    G[int.Parse(liczby[0])].Add(int.Parse(liczby[1]));
    G[int.Parse(liczby[1])].Add(int.Parse(liczby[0]));
}

foreach (var item in G)
{
    Console.Write(item.Key + " - ");
    foreach (var item1 in item.Value)
    {
        Console.Write(item1 + " ");
    }
    Console.WriteLine();
}

//a) Oblicz sumę wierzchołków grafu
int suma = 0;
foreach (var item in G)
{
    suma += item.Key;
}
Console.WriteLine("suma: " + suma);
//b) Podaj ilość wierzchołków bez sąsiadów
Console.WriteLine("puste:");
foreach (var item in G)
{
    if (item.Value.Count == 0) Console.WriteLine(item.Key);
}
//c) Sprawdź czy isnieje krawędź między a i b
Console.WriteLine("daj dwie krawędzie");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
bool flaga = false;
foreach (var item in G[x])
{
    foreach (var item1 in G[y])
    {
        if (item == y || item1 == x)
        {
            flaga = true;
            break;
        }
    }
}
if (flaga) Console.WriteLine("jest krawędź miedzy nimi");
else Console.WriteLine("nie maja wspolnej krawedzi");



Console.ReadKey();