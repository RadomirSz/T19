/*for (int i = 100; i < 1000; i++)
    if (i %5 == 0 || i%6==0 || i%11==0)
    {
        Console.WriteLine(i); 
    }*/

// int n = int.Parse(Console.ReadLine());
// for (int i = 1; i <= n; i++);
// {
//   Cosole.WriteLine("*-|"*n)
// }
// // Zad 2 - PRE
// // Tabliczka mnożenia

// /*for (int i = 1; i < 11; i++)
// {
// 	for (int j = 1; j < 11; j++)
// 	{
// 		Console.Write(i*j + "\t");
// 	}
// 	Console.WriteLine();	
// }*/

// /*
// *
// **
// ***
// ****
// ****
// ***
// **
// *
//    *
//   **
//  ***
// ****
//  */
// int n = int.Parse(Console.ReadLine());
// for(int i = 0; i < n; i++)
// {
// 	for (int j = 0; j < i+1; j++)
// 	{
// 		Console.Write("*");
// 	}
// 	Console.WriteLine();
// }

// Console.WriteLine();
// Console.WriteLine();

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n - i; j++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();
// Console.WriteLine();

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n-i-1; j++)
//     {
//         Console.Write(" ");
//     }
//     for (int k = n-i-1; k < n; k++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();
// Console.WriteLine();
//    *
//   **
//  ***
// ****

// ****
//  ***
//   **
//    *
/*int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        Console.Write(" ");
    }
    for (int k = n - i - 1; k < n; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    for (int k = i; k < n; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/


/*int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1;i++)
{
    for (int j = 1; j < n + 1; j++)
        if (i >= j)         Console.WriteLine("*");
        else                Console.WriteLine(" ");
    Console.WriteLine();
}


for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
        if (n-j+1 >= i) Console.Write("*");
        else Console.Write(" ");
    Console.WriteLine();
}
*/
//zad7kp3a
/*int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (i == 1 || j == 1 || j == n || i == n || (i == n/2+1 && j==n/2+1))               Console.Write("*");
        else                                                                                Console.Write(" ");
    }
    Console.WriteLine();
}*/
//zad5
/*int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (j == n / 2 + 1)                     Console.Write("*");
        else if (i == n / 2 + 1)                     Console.Write("?"); 
        else                                    Console.Write(" ");

    }
    Console.WriteLine();
}*/

int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (i == j) Console.Write("*");
        else if (i == n / 2 + 1) Console.Write("?");
        else Console.Write(" ");

    }
    Console.WriteLine();
}










// j = kolumny i = wiersze
