using System.Globalization;
using System.Runtime.Serialization.Formatters;

/*int sumap = 0;
int suman = 0;
int[] T = new int[100];
Random r = new Random();
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(10, 100);
}
for (int i = 0; i < T.Length; i++)
{
    if (T[i] % 2 == 0)
    {
        sumap = sumap + T[i];
    }
    else
    {
        suman = suman + T[i];
    }    
}
Console.WriteLine(sumap +" "+suman);*/
//tablice 2-wymiarowe

/*int[,] T2D = new int[5,5];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(T2D[i,j] +'\t');
    }
    Console.WriteLine("");
}

*/
// zadeklaruj macierz a'la sudoku
/*int[,] M = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(M[i,j] + '\t');
    }
    Console.WriteLine("");
}*/
// stwórz losową macierz 4x4 zawierającą dowolne liczby
/*int [,] O = new int[4, 4];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine(M[i, j] + '\t');
    }
    Console.WriteLine();
}*/

//wymiary macierzy ... 
/*int[,] M = new int[3, 5];
Console.WriteLine(M.Length);
Console.WriteLine(M.GetLength(0));
*/

//wypelnij MACIERZ 3 5 LICZBAMI 2 CYFROWYMI korzystajac z getlenght
int[,] M = new int[3, 5];
Random r = new Random();
for (int i = 0; i < M.GetLength(0); i++)
{
    for (int j = 0; j < M.GetLength(1); i++)
        M[i, j] = r.Next(0, 10);
}
for (int i = 0; i < M.GetLength(0); i++)
{
    for (int j = 0; i < M.GetLength(1);i++)
    {
        Console.WriteLine(M[i,j]+'\t');
    }
    Console.WriteLine();
}
