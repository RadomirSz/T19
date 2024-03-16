
// Zad 1
/*int suma = 0;
for (int i = 100; i < 1000; i++)
{
    suma += i;
}
Console.WriteLine(suma);*/

// Zad 2
/*int suma = 0;
int ilosc = 0;
for (int i = 12; i < 100; i++)
{
    if (i % 6 == 0)
    {
        suma += i;
        ilosc++;
    }
}
Console.WriteLine($"suma to: {suma}, ilosc to: {ilosc}");*/

// Zad 3
/*
int max = 0;
Random r = new Random();
for (int i = 0; i < 4; i++)
{
    int losowa = r.Next(1000, 10000);
    if (losowa > max)
    {
        max = losowa;
    }
}
Console.WriteLine(max);*/

// Zad 4
/*int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (a > 0)
{
    int ost = a % 10;
    sum += ost;
    a /= 10;
}
Console.WriteLine("Suma cyfr w liczbie: " + sum);*/

// Zad 5
/*int a = int.Parse(Console.ReadLine());
int min = 9;
while (a > 0)
{
    int ost = a % 10;
    if (ost < min)
    {
        min = ost;
    }
    a /= 10;
}

Console.WriteLine(min);*/

// Algorytmy

int gcd(int a, int b) 
{
    while (b > 0) 
    {
        int r = a % b;
        a = b;
        b = r;
    }
    return a;
}
int nww(int a, int b)
{ return a * b / gcd(a, b); }
// Zad 1
/*int a = int.Parse(Console.ReadLine());
bool czypie(int a)
{
    for (int i = 2; i < Math.Sqrt(a); i++)
    {
        if (a % i == 0)
        {
            return false;
        }
    }
    return true;
}
Console.WriteLine(czypie(a));*/
// Zad 2
/*int a = int.Parse(Console.ReadLine());
bool czyniepie(int a)
{
    for (int i = 2; i < Math.Sqrt(a); i++)
    {
        if (a % i == 0)
        {
            return true;
        }
    }
    return false;
}
Console.WriteLine(czyniepie(a));*/
// Zad 3

/*int c = int.Parse(Console.ReadLine());
bool czypierwszaz24(int a)
{
    if (gcd(c, 24) == 1)
        return true;
    else return false;
}
Console.WriteLine(czypierwszaz24(c));*/
// Zad 4
/*string a = Console.ReadLine();
int k = Convert.ToInt32(Console.ReadLine());
string cezar(string a,int k)
{
    string nowy="";
    for (int i = 0; i < a.Length; i++)
    {
        nowy += (char)(98 + ((int)a[i] + k - 98) % 26);
    }
    return nowy;
}
Console.WriteLine(cezar(a,k));*/
// Zad 5
/*
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());

int nww1 = nww(b, d);

int x = a * (nww1 / b);
int y = c * (nww1 / d);
int z = x + y;

Console.WriteLine($"{a}/{b} + {c}/{d} = {z}/{nww1}");
int licznik = 0;
if (gcd(z, nww1)!=1)
{
    int gcd1 = gcd(z, nww1);
    z = z / gcd1;
    nww1 = nww1 / gcd1;
}
if (z == nww1) Console.WriteLine(1);
else if (z > nww1) 
{
    while (z > nww1)
    {
        z -= nww1;
        licznik++;
    }
    Console.WriteLine($"{licznik} {z}/{nww1}");
}
else Console.WriteLine($"{z}/{nww1}");*/
// Zad 6
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine(nww(a,b));*/

// Napisy
//Zad 1

/*int ilosc = 0;
string c = Console.ReadLine();
foreach (char item in c)
{ 
    if (item == 'c' || item == 'C')
    { ilosc++; }
}*/
// Zad 2

/*
Console.WriteLine("czy twój napis jest nierosnący?");
string a = Console.ReadLine();
bool rosniecie(string a)
{
    for (int i = 0; i < a.Length - 1; i++)
    {
        if ((int)a[i] >= (int)a[i + 1])
        {
            return true;
        }
    }
    return false;
}
Console.WriteLine(rosniecie(a));*/
// Zad 3
/*string a = Console.ReadLine();
string b = Console.ReadLine();
string c = Console.ReadLine();

if (a.Length > b.Length && a.Length > c.Length)
{ Console.WriteLine("1 napis jest najdluzszy"); }
else if (b.Length > a.Length && b.Length > c.Length)
{ Console.WriteLine("2 napis jest najdluzszy"); }
else if (c.Length > b.Length && c.Length > a.Length)
{ Console.WriteLine("3 napis jest najdluzszy"); }
else { Console.WriteLine("nie ma najdluzszego"); }*/