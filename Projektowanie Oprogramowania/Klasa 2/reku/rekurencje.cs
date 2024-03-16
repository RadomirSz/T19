/*for (int i = 0; i < 6; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine();*/

/*void rel(int n)
{
    if (n == 6) return;
    Console.WriteLine(n + " ");
    rel(n + 1);
}

rel(1);*/

/*void re2(int n)
{
    if (n==0) return;
    Console.Write(n + " ");
    re2(n - 1);
    Console.Write(n + " ");
}
re2(6);*/


/*int suma = 0;
for(int i = 0; i < 10; i++) 
{
    suma += i;
}
Console.WriteLine(suma);
int re3(int n)
{
    if(n == 0) return 0;
    return re3(n - 1) + n;
}
Console.WriteLine(re3(9));*/


//####################################

/*int s4 = 0;
for (int i = 10; i < 100; i += 2)
{
    s4 += i;
}
Console.WriteLine(s4);

int re4(int n)
{
    if (n < 10) return 0;
    return re4(n - 2) + n;
}
Console.WriteLine(re4(98));*/

//#######################################
//int n = 4;
/*int re5(int n)
{
    if (n == 1) return 3;
    return re5(n - 1) + n * 3;
}
Console.WriteLine(re5(3));

int re5b(int n)
{ 
    if(n==1) return 12;
    return re5b(n - 1) + 11;
}

int s5b = 0;
for (int i = 0; i <= n; i++)
{
    s5b += re5b(i);
}*/

//1,4,9,16
/*int r5d(int n)
{
    if(n == 1) return 1;
    return r5d(n - 1) + 2 * (n - 1) + 1;
            
}
int s5d = 0;
for (int i = 0; i <= n; i++)
{
    s5d += r5d(i);
}

Console.WriteLine(s5d);




double r6a(int n)
{
    if (n == 1) return 1.5;
    if (n == 2) return 1;
    if (n == 3) return 0.5;
    return r6a(n - 1) * 2 - r6a(n - 3);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(r6a(i) + " ");
}
*/


//a. 1  3  4   8  15   27
/*int rekuA(int n)
{
    if (n == 1) return 1;
    if (n == 2) return 3;
    if (n == 3) return 4;
    return rekuA(n - 1) + rekuA(n - 2) + rekuA(n - 3);
}
*/
//e. 1   4    3    16     5     64     7    256   9   1024    
/*int rekuE(int n)
{
    if (n == 1) return 1;
    if (n == 2) return 4;
    if(n%2 != 0) return n;
    return rekuE(n - 2) * 4;
}
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(rekuE(i));
}*/


//8. Wyznacz sumę cyfr wpisanej przez usera liczby (iter + reku)

/*int suma = 0;
int n = int.Parse(Console.ReadLine());

while(n > 0)
{ 
    suma += n%10;
    n = n/10;
}
Console.WriteLine(suma);
*/

/*int reku8(int n)
{
    if (n == 0) return 0;
    return reku8(n / 10) + n % 10;
}
Console.WriteLine(reku8(123456));
*/

//9. Zamiana dec na bin (iter + reku)

//int a = 67;
//string bin = "";
//1000011
/*while(a>0)
{
    bin = a % 2 + bin;
    a /= 2;
}
Console.WriteLine(bin);*/
/*
void reku9(int n)
{
    if (n == 0) return;
    reku9(n / 2);
    Console.Write((n % 2));
}
reku9(a);*/
/*int w = 0;
int rekku2(int n)
{
    if (n == 1) return 1;
    else
    { 
    w = rekku2(n/2);
        if (n % 2 == 1) return w + 1;
        else return w - 1;
    }
}
Console.WriteLine(rekku2(32));*/
