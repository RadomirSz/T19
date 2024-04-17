//zad 0
/*
string[] input = Console.ReadLine().Split("-");


jaka(input);
void jaka(string[] S)
{
    // maleje = 1
    // wzrasta = 2
    //nijaki = 0
    //równy = 3
    int flaga = 0;
    int tempflaga = 0;
    for (int i = 0; i < S.Length-2; i++)
    {
        if (i % 2 == 1)
        {
            if (int.Parse(S[i]) >= int.Parse(S[i + 1]) && int.Parse(S[i + 1]) >= int.Parse(S[i + 2])) tempflaga = 1;
            if (int.Parse(S[i]) <= int.Parse(S[i + 1]) && int.Parse(S[i + 1]) <= int.Parse(S[i + 2])) tempflaga = 2;
            if (int.Parse(S[i]) == int.Parse(S[i + 1]) && int.Parse(S[i + 1]) == int.Parse(S[i + 2])) tempflaga = 3;
        }
        if (i % 2 == 0)
        {
            if (int.Parse(S[i]) >= int.Parse(S[i + 1]) && int.Parse(S[i + 1]) >= int.Parse(S[i + 2])) flaga = 1;
            if (int.Parse(S[i]) <= int.Parse(S[i + 1]) && int.Parse(S[i + 1]) <= int.Parse(S[i + 2])) flaga = 2;
            if (int.Parse(S[i]) == int.Parse(S[i + 1]) && int.Parse(S[i + 1]) == int.Parse(S[i + 2])) flaga = 3;
        }
        if (flaga != tempflaga && i == (S.Length-S.Length/2)-1)
        {
            Console.WriteLine("nijaki");
            break;
        }
    }
    if (flaga == tempflaga && flaga == 1) Console.WriteLine("małorolna");
    if (flaga == tempflaga && flaga == 2) Console.WriteLine("Wielkomiejska");
    if (flaga == tempflaga && flaga == 3) Console.WriteLine("małomiasteczkowa");
}
//tak istnieje na przykład:
int[] przyklad = new int[] { 1, 1, 1, 1, 1, 1 };
*/
//zad 1
/*Random r = new Random();
int[] T = new int[10];
for (int i = 0; i < 10; i++)
{
    T[i] = r.Next(-9, 10);
}

int suma = 0;
int tempsuma = 0;
int pierwsza = 0;
int ostatnia = 0;
int dlugosc = 1;

for (int i = 1; i < 9; i++)
{
    
}

for (int i = 1; i < 9; i++)
{
    if (T[0] == T[0 + 1] - 1 || T[0] == T[0 + 1] + 1) { tempsuma += T[0]; }
    
    if (T[i] == T[i + 1] - 1 || T[i] == T[i + 1] + 1 || T[i] == T[i - 1] - 1 || T[i] == T[i - 1] + 1)
    {
        tempsuma += T[i];
        dlugosc++;

    }
    else
    {
        if (tempsuma > suma)
        {
            pierwsza = T[i - dlugosc+1];
            
            ostatnia = T[i - 1];
            suma = tempsuma;
        }
        dlugosc = 1;
        tempsuma = 0;
    }
}


foreach (var item in T)
{
    Console.Write(item + " ");
}
Console.WriteLine();
Console.WriteLine($"pierwsza:{pierwsza}, ostatnia:{ostatnia},suma:{suma}");
*/

//zad 2
/*Random r = new Random();
List<List<List<int>>> lista = new List<List<List<int>>>();

Console.WriteLine("daj n");
int n = int.Parse(Console.ReadLine());
int[] s = new int[n];
for (int i = 0; i < n; i++)
{
    lista.Add(new List<List<int>>());
    for (int j = 0; j < n; j++)
    {
        lista[n].Add(new List<int>());
        for (int k = 0; k < n; k++)
        {
            lista[n][n].Add(r.Next(0, 10));
        }
    }
}*/