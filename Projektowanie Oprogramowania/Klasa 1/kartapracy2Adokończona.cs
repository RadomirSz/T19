
//zad1

int a = int.Parse(Console.ReadLine());  
int b = int.Parse(Console.ReadLine());

if ((a+b)%2 == 0)
{
    Console.WriteLine("TAK");
}
else
{
    Console.WriteLine("NIE");
}

//zad2

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if ((a+b)/2>Math.Sqrt(a*b));
{
    Console.WriteLine("TAK");
}
else
{
    Console.WriteLine("NIE");
}

//zad3
int k = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());  
int m = int.Parse(Console.ReadLine());  

if (k == l && m!=k && m!=l)
{
    Console.WriteLine("równe są k i l");
}
else
{
    if (k!=l && m==k && m!=l)
    {
        Console.WriteLine("równe są m i k");
    }
    else
    {
        if (k!=l && m!=k && m==l)
        {
            Console.WriteLine("równe są m i l");
        }
        else
        {
            Console.WriteLine("wszystkie lub żadne z liczb nie są równe");
        }
    }
}
//zad4
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());  
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

if (a<b && a<c && a<d)
{
    Console.WriteLine("a jest najmniejsze");
}
else
{
    if (b < a && b < c && b < d)
    {
        Console.WriteLine("b jest najmniejsze");
    }
    else 
    {
        if (c < a && c < b && c < d)
        {
            Console.WriteLine("c jest najmniejsze");
        }
        else
        {
            if (d<a && d<b && d<c)
            {
                Console.WriteLine("d jest najmniejsze");
            }
        }

    }
}
//zad5
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if ((a<b+c) && (b<a+c) && (c<a+b))
{
    Console.WriteLine("da się zbudować z nich trójkąt");
}
else
{
    Console.WriteLine("nie da się zbudować z nich trójkąta");
}

//zad6
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());  
int c = int.Parse(Console.ReadLine());
if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Trójkąt można zbudować z tych liczb");
    if (a*a + b*b == c*c || b*b + c*c == a*a || c*c + a*a == b*b)
    {
        Console.WriteLine("trójkąt będzie prostokątny");
    }
    else if (a*a + b*b < c*c || b*b + c*c < a*a || c*c + a*a < b*b)
    {
        Console.WriteLine("trójkąt będzie rozwartokątny");
    }
    else if (a*a + b*b > c*c || b*b + c*c > a*a || c*c + a*a > b*b)
    {
        Console.WriteLine("trójkąt będzie ostrokątny");
    }
}
else 
{
    Console.WriteLine("Trójkąta nie można zbudować z tych liczb ");
}