// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());
// Console.WriteLine('arytmetyczny: ');
// if (b - a == c - b || a - b == b - c)
// {
//     Console.WriteLine('tak');
// }
// else 
// {
//     Console.WriteLine('nie');
// }
// Console.WriteLine('geometryczny: ');
// if (b/a == c/b)
// {
//     Console.WriteLine('tak')
// }
// else
// {
//     Console.WriteLine('nie')
// }
// Console.WriteLine('malejące: ');
// if (a > b && b > c)
// {
//     Console.WriteLine('tak')
// }
// else
// {
//     Console.WriteLine('nie')
// }
// Console.WriteLine('rosnace: ');
// if (a < b && b < c)
// {
//     Console.WriteLine('tak')
// }
// else
// {
//     Console.WriteLine('nie')
// }
// //zad2
// int suma = 0;
// for (int i = 100; i<1000 ; i++)
// {
//     if (i%8==0 && i%16 != 0);
//         {
//             suma += i
//         }
// }
// Console.WriteLine(suma);
//zad3
/*int liczba = 0;
int ilosc = 0;

for (int i = 99; i > 9; i--)
{
    if (i % 7 == 0) 
    {
        liczba = i;
        break;
    }
}

for (int j = 1000; j < 10000; j++)
{
    if (j % liczba == 0)
    {
        ilosc += 1;
    }
}
Console.WriteLine(ilosc);
*/
//zad4
/*int ilosc = 0;
for (int i = 10; i < 100; i++)
{
    if (2 * (i % 10) <= i / 10)
    {
        ilosc += 1;
    }
}
Console.WriteLine(ilosc);*/
//zad5
/*int ilosc = 0;
int suma = 0;
for (int i = 100; i < 1000; i++)
{
    if (i / 100 > i % 10 + (i % 100 - i % 10))
    {
        suma += i;
        ilosc += 1;
    }
}
Console.WriteLine(ilosc);
Console.WriteLine(suma);*/
//zad6
/*int n = int.Parse(Console.ReadLine());
int ilosc = 0;
int suma = 0;
for (int i = 10; i < 100; i++)
{
    if (i % 19 == 0)
    {
        suma += i;
        ilosc += 1;
    }

    if (ilosc == n)
    {
        break;
    }
}
Console.WriteLine(suma);*/
//zad7
/*int suma = 0;
int ilosc = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 999; i > 99; i--)
{
    if (i % 37 == 0)
    {
        suma += i;
        ilosc += 1;
    }
    if (ilosc == n)
    {
        break;
    }
}
Console.WriteLine(suma);
*/
//zad8
/*int suma = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    suma += ((3 * i - 1) * ((int)Math.Pow(-1, i - 1)));
}
Console.WriteLine(suma);*/

//zad9
//XD          1 ∗ (−2) ∗ 4 ∗ (−8) ∗ 16 ∗ (−32).....

//zad11
/*int licznik = 1;
int mianownik = 1;
int suma = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < licznik; i++)
{
    mianownik = i * i;
    suma += licznik / mianownik;
    licznik += 2;
}
Console.WriteLine(suma);
*/





//zad2
/*int suma = 0;
for (int i = 100; i < 1000; i++) 
{
    if (i % 8 == 0 && i % 16 != 0)
    {
        suma += i;
    }
}
Console.WriteLine(suma);
*/
//zad3


//zad8
/*int ciag1 = 2;
int suma = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if (ciag1 % 2 == 0)
    {
        suma += ciag1;
        ciag1 += 3;
    }
    else 
    {
        suma -= ciag1;
        ciag1 += 3;
    }
}
Console.WriteLine(suma);*/


//zad9 tu coś źle
/*
int ciag = 1;
int suma = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n; i++)
{
    if (i % 2 == 0)
    {
        suma *= (-ciag);
        ciag = ciag * 2;
    }
    else
    {
        suma *= ciag;
        ciag *= 2;
    }

}
Console.WriteLine(suma);*/




//zad3
/*int ilosc = 0;
int liczba = 0;
for (int i = 100; i > 10; i--)
{
    if (i % 7 == 0)
    {
        liczba = i;
        break;
    }
}

for (int i = 1000; i < 10000; i++)
{
    if (i % liczba == 0)
    {
        ilosc++;
    }
}
Console.WriteLine(liczba);
Console.WriteLine(ilosc);*/

//zad4
/*int ilosc = 0;
for (int i = 10; i < 100; i++) 
{
    if (i / 10 >= (i % 10) * 2)
    {
        ilosc++;
    }
}
Console.WriteLine(ilosc);
*/
//zad5
/*
int suma = 0;
int ilosc = 0;
for (int i = 100; i < 1000; i++)
{
    if (i/100 > i%10+(i%100-i%10))
    {
        suma += i;
        ilosc++;
    }
}

Console.WriteLine(suma);
Console.WriteLine(ilosc);*/

//zad6
/*int suma = 0;
int ilosc = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 10; i < 100; i++)
{
    if (i % 19 == 0)
    {
        suma += i;
        ilosc++;
    }
    if (ilosc == n)
    {
        break;
    }
}
Console.WriteLine(suma);*/


//zad7
/*int suma = 0;
int ilosc = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 1000; i > 100; i--)
{
    if (i % 37 == 0)
    {
        suma += i;
        ilosc++;
    }
    if (ilosc == n)
    {
        break;
    }
}
Console.WriteLine(suma);*/

//zad8
/*int ciag = 2;
int suma = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++) 
{
    if (ciag % 2 == 0)
    {
        suma += ciag;
        ciag += 3;
    }
    else 
    { 
        suma-=ciag;
        ciag += 3;
    }
}
Console.WriteLine(suma);*/

//zad9 pomijam


//zad11
/*int suma = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    suma += (2 * i - 1) / (int)Math.Pow(i, 2);
}
Console.WriteLine(suma);
*/


//zad13 źle
/*double suma = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    suma += (2 * i) / ((int)Math.Pow(i, 3)+2);
}
Console.WriteLine(suma);

*/

//fibbonacci
/*int a = 0;
int b = 1;
int n = int.Parse(Console.ReadLine());
Console.WriteLine(a);
Console.WriteLine(b);
for (int i = 0; i < n; i++)
{
    int temp = a;
    a = b;
    b = a + temp;
    Console.WriteLine(b);
}*/

//zad6
/*int licznik = 0;
int suma = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 10; i < 100; i++)
{
    if (i % 19 == 0)
    {
        suma += i;
        licznik++;
    }
    if (licznik == n)
    {
        break;
    }
}
Console.WriteLine(suma);
*/
//zad8

/*int n = int.Parse(Console.ReadLine());
int ciag = 2;
int suma = 0;
for (int i = 0; i < n; i++)
{
    if (ciag % 2 == 0)
    {
        suma += ciag;
        ciag += 3;
    }
    else 
    {
        suma -= ciag;
        ciag += 3;
    }
}
Console.WriteLine(suma);*/

/*
int suma = 0;
for (int i = 100; i < 1000; i++)
{
    if (i % 8 == 0 && i % 16 != 0)
    {
        suma += i;
    }
}
Console.WriteLine(suma);
*/
//3
/*int liczba = 0;
int ilosc = 0;
for (int i = 99; i > 10; i--)
{
    if (i%7==0)
    {
        liczba = i;
        break;
    }
}
for (int j = 1000; j < 10000; j++)
{
    if (j % liczba == 0)
    {
        ilosc++;
    }
}
Console.WriteLine(ilosc);
*/
/*int ilosc = 0;
for (int i = 10; i < 100; i++)
{
    if (i / 10 >= 2 * (i % 10))
    {
        ilosc++;
    }
}
Console.WriteLine(ilosc);
*/
//zad9
/*int input1 = int.Parse(Console.ReadLine());
int ciag1 = 1;
int iloczyn = 1;
for (int i = 1; i < input1+1; i++)
{
    if (i%2 == 0)
    {
        int temp = ciag1;
        ciag1 -=2*ciag1 ;
        iloczyn *= ciag1;
        ciag1 = temp;
        ciag1 *= 2;
        temp = 0;
    }
    else
    {
        iloczyn *= ciag1;
        ciag1 *=2;
    }
}
Console.WriteLine(iloczyn);*/
//zad13/14
/*float suma = 0;
float ciag1 = 2;
float n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    suma += ciag1 / (float)(Math.Pow(i, 3) + 2);
    ciag1 += 2;
}
Console.WriteLine(suma);
Console.ReadLine();
*/

//zad12
/*int n = int.Parse(Console.ReadLine());
float suma = 0;
float licznik = 0;
float mianownik = 0;
float licznikdod = 1;
//licznik
for (int i = 0; i < n; i++)
{
    licznik += licznikdod;
    licznikdod += 2;
}
//mianownik
for (int j = 1; j < n+1; j++)
{
    mianownik += ((int)Math.Pow(j, 2));
}
suma = licznik / mianownik;
Console.WriteLine(suma);*/


//zad11
/*int n = int.Parse(Console.ReadLine());
float suma = 0;
int licznik = 1;
float mianownik = 0;
float licznikg = 0;
for (int i = 0; i < n; i++)
{
    licznikg = licznik;
    mianownik = ((int)Math.Pow(i+1, 2));
    suma += licznikg / mianownik;
    licznik+=2;
}
Console.WriteLine(suma);*/

//zad15
/*float ciag1 = 3;
float ciag2 = 1;
float iloczyn = 1;
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    iloczyn = iloczyn * (ciag1 / ciag2);
    float temp = ciag2;
    ciag1++;
    ciag2 = (temp * 2) + 1;
    temp = 0;
}
Console.WriteLine(iloczyn);*/


//zad16

//cos pokręciłem

int a = 0;
int b = 1;
int n = int.Parse(Console.ReadLine());
float licznik = 0;
float mianownik = 0;
float iloczyn = 0;
float mian = 1;


for (int i = 0; i < n; i++)
{
    int temp = a;
    a = b;
    b = a + temp;
    Console.WriteLine(b);
    licznik = b;
    mianownik = mian;
    iloczyn *= licznik / mianownik;
    mian *=2;
}

Console.WriteLine(iloczyn);