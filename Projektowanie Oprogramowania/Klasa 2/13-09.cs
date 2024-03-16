﻿
using System.Runtime.CompilerServices;

int nww(int a, int b)
{
    return (a * b) / nwd(a, b);
}
int nwd(int a, int b)
{
    while (b > 0)
    {
        int r = a % b;
        a = b;
        b = r;
    }
    return a;
}



//1.User podaje NWD i NWW dwóch liczb. Napisz program, który znajdzie te liczby.

//brute force
/*int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
for (int i = 0; i < 10000; i++)
{
    for (int j = 0; j < 10000; j++)
    {
        if (nwd(i, j) == x && nww(i, j) == y)
        { 
            Console.WriteLine($"{i},{j}"); 
        }
    }
}*/

// inaczej

/*int iloczyn = x * y;
for (int i = 1; i < iloczyn; i++)
{
    if (iloczyn % i == 0 && nwd(i, iloczyn / i) == x && nww(i,iloczyn/i) == y && i < iloczyn)
    {
        Console.WriteLine(i + " " + iloczyn/i);
    }
}*/


//2. Sprawdź czy suma dwóch ułamków podanych przez usera jest ułamkiem niewłaściwym.
/*
string pier = Console.ReadLine();
string drug = Console.ReadLine();

string[] P = pier.Split("/");
string[] D = drug.Split("/");

int a = int.Parse(P[0]);
int b = int.Parse(P[1]);
int c = int.Parse(D[0]);
int d = int.Parse(D[1]);

int mianownik = nww(b, d);
int licz1 = mianownik * a / b;
int licz2 = mianownik * c / d;

if (licz1 + licz2 > mianownik) Console.WriteLine("Tak");
else Console.WriteLine("NIE");*/
//3. Sprawdź czy wieksza jest suma dwóch wpisanych przez usera ułamków czy suma ich odwrotności.

//4. Sprawdź czy w danym napisie więcej jest spółgłosek czy samogłosek.
/*char[] S = new char[6]{'a', 'e', 'i', 'o', 'u', 'y'};
string napis = Console.ReadLine();

int liczniksamo = 0;
int licznikspol = 0;

foreach (char i in napis)
{
    bool flaga = true;
    for (int j = 0; j < 6; j++)
    {
        if (i == S[j])
        { 
            liczniksamo += 1;
            flaga = false;
        }
    }
    if (flaga) { licznikspol += 1; }
}


if (liczniksamo > licznikspol) Console.WriteLine("samoglosek wiecej");
else if (licznikspol == liczniksamo) Console.WriteLine("jest tyle samo");
else Console.WriteLine("spolglosek wiecej");*/



//5. Podaj której literki jest najwięcej w podanym napisie i jaka to jest literka.

//6. Znajdź trzy takie liczby, których suma, a także suma każdej pary tych liczb jest kwadratem innej liczby.

//7. Dwie wieżyce, jedna wysokości 30 stóp, druga 40 stóp, oddalone są od siebie o 50 stóp.
//Pomiędzy nimi znajduje się wodotrysk, do którego zlatują dwa ptaki z wierzchołków obu wieżyc
//i lecąc z jednakową prędkością przybywają w tym samym czasie.
//Napisz program, który obliczy jest dłuższa odległość pozioma wodotrysku jednej z wieżyc?

//8. Brajanek z Dżesiką grają w siedem. Gra polega na tym, że jeden z graczy podaje granice przedziału <a, b>
//a drugi z nich musi szybko odpowiedzieć, ile w tym przedziale jest liczb,
//które są podzielne przez siedem, albo suma ich cyfr jest podzielna przez siedem (lub jedno i drugie).
//Napisz program, który pomaga w takich obliczeniach.

//9. Halinka wspina się na schody w centrum handlowym. Za każdym razem, gdy dziewczynka wspina się na nowe schody,
//zaczyna liczyć na głos po kolei od 1 do ilości stopni. Na przykład,
//jeśli wspina się na dwa zestawy schodów – jeden z 3 stopniami, a drugi z 4 stopniami –
//będzie liczyć tak: 1, 2, 3, 1, 2, 3, 4.Masz dane wszystkie liczby, które Halinka wypowiedziała
//podczas całej swojej wycieczki po centrum i Twoim zadaniem jest obliczenie, ile zestawów schodów „zaliczyła”.

//10. Brajanek wybrał się na spacer do parku. Przysiadł na chwilę na parkowej ławce i obserwował
//przechadzających się ludzi.
//W parku znajduje się n ławek ponumerowanych od 1 do n. Kiedy Brajanek zaczął swoje
//obserwacje, na i-tej ławce siedziało ai osób. Do parku przybyło właśnie m osób i każda chciałaby
//znaleźć sobie miejsce na ławce.
//Niech k oznacza największą liczbę osób siedzących na jednej ławce (po przyjściu tych dodatkowych m osób). 
//Jaka jest minimalna, a jaka maksymalna wartość k?

// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());
// int m = int.Parse(Console.ReadLine());

// int max = 0, k;
// if (a > b && a > c) max = a;
// if (b > c && b > a) max = b;
// if (c > a && c > b) max = c;

// k = max + m;
// Console.WriteLine("max wartość k to:" + k);

// while (m > 0)
// {
//     if (a < b || a < c) a++ ; m--;
//     if (b < c || b < a) b++ ; m--;
//     if (c < a || c < b) c++ ; m--;
//     if (a == b && a == c) a++; m--;
// }

//lob is in the air