//tablice proste
/*
int[] T = new int[3];//deklaracja
T[0] = 4;
T[1] = 9;
T[2] = 1; //definicja
int[] D = new int[3] { 1, 2, 3 };
//przechodzenie pętli - 2 pętle(for i foreach)
for (int i=0; i < D.Length; i++)
{
    Console.Write(D[i]+" ");
}
Console.WriteLine("\n");

foreach (var item in D)
{
    Console.Write(item);
}
Console.WriteLine("\n");

//tablice 2 wymiarowe
int[,] M = new int[2, 3];
M[0, 0] = 3;
M[0, 1] = 7;
M[0, 2] = 4;
M[1, 0] = 9;
M[1, 1] = 1;
M[1, 2] = 2;
int[,] N = new int[,] { {2,3,4 }, {5,6,7 }, {8,9,10 },{11,12,13 } };
for (int i = 0; i < N.Length; i++) 
{
    Console.WriteLine(N[i/3,i%3] + " ");
}
Console.WriteLine("\n");


foreach (var item in N) 
{
    Console.WriteLine(item + " ");
}

for (int i = 0; i < N.GetLength(0); i++)
{
    for (int j = 0; j < N.GetLength(1); j++)
    {
        Console.WriteLine(N[i,j]+"\t");
    }
    Console.WriteLine("");
}
Console.WriteLine();*/
//listy
/*//enumy
//typ wyliczeniowy (enum) od enumeration
enum Dni { pon, wt, sr, czw };
class lol
{
    public void Main()
    {
        Dni dzien = Dni.pon;
        Console.WriteLine(dzien);

    }
}*/


using System.Collections;
ArrayList A = new ArrayList();
A.Add(1);
A.Add(3);
A.Add(7);
A.Remove(3);
A.RemoveAt(1);

foreach (int i in A)
{
    Console.WriteLine(i + " ");
}
for (int i = 0; i < A.Count; i++)
{
    Console.WriteLine(A[i] + " ");
}
