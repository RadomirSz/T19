//zad1
for (int i = 1; i < 31; i++)
{
    Console.WriteLine("dzień " + i);
}
//zad2

for (int i = 1; i <= 10; i++)
    if (i % 2 != 0)
    {
        Console.WriteLine(i * i);
    }
//zad3
for (int i = 1000; i < 10000; i++)
    if (i % 379 == 0)
    {
        Console.WriteLine(i);
    }
//zad4
for (int i = 100; i < 1000; i++)
    if (i % 5 == 0 || i % 6 == 0 || i % 11 == 0)
    {
        Console.WriteLine(i);
    }
//zad5
int suma = 0;
int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    int x = int.Parse(Console.ReadLine());
    suma += x;
}
Console.WriteLine(suma);
//zad6
int suma = 0;
int k = int.Parse(Console.ReadLine());
for (int i = 1; i < 2 * k; i++)
    if (i % 2 == 0)
    {
        suma += i;
        Console.WriteLine(suma);
    }
//zad7
int suma = 0;
int m = int.Parse(Console.ReadLine());
for (int i = 11; i < (2 * m) + 10; i += 2)
{
    suma += i;
    Console.WriteLine(suma);
}
//zad8
int w = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());
int wk = 0;
int sk = w;
for (int i = 0; i < l * 12; i++)

{
    wk = (int)(sk * 0.06 / 12);
    sk += wk;
    Console.WriteLine(sk);
}
//zad9
int suma = 0;
int lista = 21;
int n = int.Parse(Console.ReadLine());
for (int i = 21; i < (n * 100) + 21; i += 100)
{
    Console.WriteLine(lista);
    suma += i;
    lista += 100;
    Console.WriteLine(suma);
}
//zad10
for (int i = 1; i < 1001; i++)
    if (i % 10 == Math.Sqrt(i) ||
        i % 100 == Math.Sqrt(i) ||
        i % 1000 == Math.Sqrt(i))
    {
        Console.WriteLine(i);
    }