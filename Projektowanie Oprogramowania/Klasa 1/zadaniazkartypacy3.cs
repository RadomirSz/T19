//zad1
/*
int n = int.Parse(Console.ReadLine()); 
for (int i = 0; i < n; i++) 
{
    Console.Write(Math.Pow(i, 3) + 3 + " "); 
}
*/
//zad2
/*
for (int i = 105; i < 1000; i = i + 15)
{ 
 Console.WriteLine(i+" ");
}
*/
//zad3
/*
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if (n % i== 0)
        {
            Console.Write(i + " ");
        }
}
*/
//zad4
// int suma = 0;
// for (int i = 10; i < 100; i++)
// {
//     suma += 1;
// }
// Console.Writeline(suma);
//zad5
int x;
int n = int.Parse(console.readline());
int suma = n * (n + 1) / 2;
for (int i = 0; i < n - 1; 1++)
{
    x = int.Parse(Console.Readline());
    suma = suma - x;
}
Console.WriteLine(suma);