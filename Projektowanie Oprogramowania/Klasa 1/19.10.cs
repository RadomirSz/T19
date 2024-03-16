using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

/*int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.WriteLine("*-|");
}
*//*
int n = int.Parse(Console.ReadLine());
int x = int.Parse(Console.ReadLine());
*//*Console.WriteLine(10*n);
Console.WriteLine(float.Parse("4")*//*
if (((n + x) / 2 > Math.Sqrt(n * x)));
{
    Console.WriteLine("arytmetyczna wieksza");
}
else
{ 
    Console.WriteLine("geo jest wieksza")
}
*/
//zad2
//int n = int.Parse(Console.ReadLine());
/*for (int i = 1; i < 11; i++)
{
    for (int j = 1; j < 11; j++)
    {
        Console.WriteLine(i * j + "\t");
    }
    Console.WriteLine();
}*/

/*
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/
Console.WriteLine();
Console.WriteLine();

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - i; j++)
    { 
        Console.Write("*");
    }
    Console.WriteLine();
}
