
using System;
int[] G = new int[10];
Random random = new Random();
for (int i = 0; i < G.Length; i++)
{
    G[i] = random.Next(1,100);
}
foreach (int item in G)
{
    Console.Write(item + " ");
}

static int quicksortHoare(int[] T,int lewy,int prawy)
{
    int i = lewy;
    int j = prawy;
    int pivot = T[(lewy + prawy) / 2];

    while (i <= j)
    {
        while (T[i] < pivot)
        {
            i++;
        }
        while (T[j] > pivot)
        {
            j = j - 1;
        }
        if (i <= j)
        { 
            int temp = T[i];
            T[i]= T[j];
            T[j]= temp;
            i = i + 1;
            j = j - 1; 
        } 
    }

    if (lewy < j)
    {
        quicksortHoare(T, lewy, j);
    }
    if (prawy > i)
    { 
        quicksortHoare(T, i, prawy); 
    }
    return 0;
}

quicksortHoare(G, 0, ((G.Length) - 1));
Console.WriteLine();
foreach (int item in G)
{
    Console.Write(item + " ");
}
