//1.Zapisz iteracyjnie i rekurencyjnie obliczanie sumy kodów ASCII wpisanego przez usera słowa
/*string slowo = "ABCD";
int suma = 0;
for (int i = 0; i < slowo.Length ; i++)
{
    suma += Convert.ToInt32(slowo[i]);
}
Console.WriteLine(suma);*/


/*int suma2 = 0;
int reku1(int n)
{
    if (n == 0)
    {
        Console.WriteLine(suma2);
        return 0;
    }
    suma2 += Convert.ToInt32(slowo[n-1]);
    return reku1(n-1);
}
Console.WriteLine(slowo.Length);
reku1(slowo.Length);*/
// ver nowak

/*int reku11(string napis)
{
    if (napis == "") return 0;
    return reku11(napis.Substring(1)) + napis[0];
}
Console.WriteLine(reku11("AAA"));*/

//2. Napisz iteracyjnie i rekurencyjnie obliczenie x^n (x do potęgi n)
/*
int x = 4; //Convert.ToInt32(Console.ReadLine());
int n = 2; //Convert.ToInt32(Console.ReadLine());
int wynik = x;
for(int i = 0; i < n-1; i++)
{
    wynik = wynik * x;
}
Console.WriteLine(wynik);
*/
/* int reku2(int n)
{
    if (n == 1) {Console.WriteLine(wynik); return 0;}
    wynik *= x;
    return reku2(n-1);
}
reku2(n);*/

//ver bartosz

/*
int reku21(int x, int n)
{
    if (n == 0) return 1;
    return reku21(x, n - 1) * x;
}
Console.WriteLine(reku21(2,5));
*/

//3. Napisz algorytmy NWD modulo i odejmowanie w wersji reku.


// int reku31(int n,int n2)
// {
//     if (n2 != 0) return reku31(n2, n % n2);
//     return n;
// }
// Console.WriteLine(reku31(21,9));


// int reku32(int n, int n2)
// {
//     if (n < n2) return reku32(n , n2-n);
//     if (n > n2) return reku32(n-n2 , n2);
//     return n;
// }
// Console.WriteLine(reku32(16,20));