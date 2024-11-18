
int nwd(int a, int b)
{
    while (b > 0)
    {
        int r = a % b;
        a = b;
        b = r;
    }
    return a;
}
bool Czypierwsza(int a)
{
    for (int i = 2; i < a / 2; i++)
    {
        if (a % i == 0) return false;
    }
    return true;
}



//zad -1
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

bool czyibra(int a, int b)
{
    if (Czypierwsza(nwd(a, b))) return false;
    return true;
}
Console.WriteLine(czyibra(a,b));
*/
//zad 0
/*
for (int i = 20; i < 51; i++)
{
    for (int j = 50; j > 19; j--)
    {
        if(czyibra(i,j)) Console.WriteLine($"{i},{j}");
    }
}
*/
//zad 1
/*Random r = new Random();
int n = int.Parse(Console.ReadLine());
int[,] M = new int[n, n];

int sprawdz(int x)
{
    if (x >= 0 && x <= 4) return 0;
    else if (x == 5 || x == 6) return 1;
    else if (x == 7 || x == 8) return 2;
    else if (x == 9)
    {
        x = r.Next(3, 5);
        return x;
    }
    return -1;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        int x = r.Next(0, 10);
        M[i, j] = sprawdz(x);
        Console.Write(M[i,j] + " ");
    }
    Console.WriteLine();
}
int suma = 0;
for (int i = 0; i < n-1; i++)
{
    for (int j = 1; j < n-1; j++)
    {
        if (i == n && j == 0)
        {
            if (M[i, j] == M[i - 1, j] + M[i, j + 1] + M[i - 1, j + 1])
            {
                suma++;
            }
        }
        else if (i == 0 && j == n)
        {
            if (M[i, j] == M[i + 1, j] + M[i, j - 1] + M[i + 1, j - 1])
            {
                suma++;
            }
        }
        else if (i == 0 && j == 0) 
        {
            if (M[i, j] == M[i + 1, j] + M[i, j + 1] + M[i + 1, j + 1])
            {
                suma++;
            }
        }
        else if (i == n && j == n)
        {
            if (M[i, j] == M[i - 1, j] + M[i, j - 1] + M[i - 1, j - 1] )
            {
                suma++;
            }
        }
        else if (j == n)
        {
            if (M[i, j] == M[i + 1, j] + M[i - 1, j] + M[i, j - 1] + M[i + 1, j - 1] + M[i - 1, j - 1])
            {
                suma++;
            }
        }
        else if (i == n)
        {
            if (M[i, j] == M[i - 1, j] + M[i, j + 1] + M[i, j - 1] + M[i - 1, j - 1] + M[i - 1, j + 1])
            {
                suma++;
            }
        }
        else if (j == 0)
        {
            if (M[i, j] == M[i + 1, j] + M[i - 1, j] + M[i, j + 1] + M[i + 1, j + 1] + M[i - 1, j + 1])
            {
                suma++;
            }
        }
        else if (i == 0)
        {
            if (M[i, j] == M[i + 1, j] + M[i, j + 1] + M[i, j - 1] + M[i + 1, j + 1] + M[i + 1, j - 1])
            {
                suma++;
            }
        }
        else
        {
            if (M[i, j] == M[i + 1, j] + M[i - 1, j] + M[i, j + 1] + M[i, j - 1] + M[i + 1, j + 1] + M[i + 1, j - 1] + M[i - 1, j - 1] + M[i - 1, j + 1])
            {
                suma++;
            }
        }
    }
}
Console.WriteLine(suma);*/

//zad 2
/*string a = Console.ReadLine();
int max = 0;
int index = 0;
int index2 = 0;
for (int i = 0; i < 10; i++)
{
    char v = a[i];
    int x = a.Count(v);
    if (x > max)
    {
        index = i;
        max = x;
    }
    if (x == max && i != index)
    {
        index2 = i;
    }
    if (x == max && i != index && i != index2)
    {
        index2 = 0;
        index = 0;
    }
}
if (index2 == 0) Console.WriteLine("nie wyszło");
else Console.WriteLine(a[index], a[index2]);*/

//zad 3

int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 0; i < n; i++)
{ 

}
