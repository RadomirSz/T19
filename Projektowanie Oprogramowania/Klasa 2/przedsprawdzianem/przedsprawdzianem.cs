
using System;

bool Czypierwsza(int n)
{
    for(int i = 2; i < n/2;i++) if(n%i==0) return false;
    return true;
}

//zad 1
//czy podana liczba jest liczbą ibrahima
// int a = Convert.ToInt32(Console.ReadLine());
// if (Czypierwsza(a) && Czypierwsza((a*2)+1)) System.Console.WriteLine("jest ibrahima");
// else System.Console.WriteLine("nie");

//zad 2
// wypisz liczby ibrahima z przedziału 2 - 100
/*
for(int i = 2; i < 101; i++)
{
    if (Czypierwsza(a) && Czypierwsza((a*2)+1))
    {System.Console.WriteLine(i);}
}

//zad 3
// wygeneruj losowo macierz 20 x 20, sprawdź ile liczb w tej macierzy ma wartość sumy sąsiadujących liczb
/*
Random r = new Random();
int[,] M = new int[20,20];

for(int i = 0; i<20;i++)
{
    for(int j = 0; j<20;j++)
    {
        M[i,j] = r.Next(0,100);
        //System.Console.Write(M[i,j] + " ");
    }
    System.Console.WriteLine(); 
}
ushort suma = 0;
for(int i = 1; i < 19;i++)
{
    for(int j = 1; j < 19;j++)
    {
        if(M[i,j] == M[i+1,j] + M[i-1,j])
        {
            suma++;
        }
    }
}
System.Console.WriteLine(suma);
*/

//zad 4
// użytkownik podaje ciąg cyfr bez spacji sprawdzamy która występuje najrzadziej z pierwszych 40 cyfr
// string a = Console.ReadLine();

// byte[] T = {0,0,0,0,0,0,0,0,0,0};

// for(int i = 0; i<40;i++)
// {
//     if(a[i] == '0') T[0] += 1;
//     else if(a[i] == '1') T[1] += 1;
//     else if(a[i] == '2') T[2] += 1;
//     else if(a[i] == '3') T[3] += 1;
//     else if(a[i] == '4') T[4] += 1;
//     else if(a[i] == '5') T[5] += 1;
//     else if(a[i] == '6') T[6] += 1;
//     else if(a[i] == '7') T[7] += 1;
//     else if(a[i] == '8') T[8] += 1;
//     else if(a[i] == '9') T[9] += 1;
// }
// int tttt = T.Min();
// System.Console.WriteLine(tttt);
// foreach(byte i in T) System.Console.Write(i + " ");

//zad 5
// do podanej liczby pierwszej większej od 7 podaj 3 liczby pierwsze nieparzyste których suma jest równa tej liczbie
System.Console.WriteLine("liczbę pierwszą większą niż 7");
int n = int.Parse(Console.ReadLine());
int suma = 0;
int i = 0;
while(suma != n)
{
    if(Czypierwsza(i)&& i%n!=0 && suma + i <=n)
    {
        suma += i;
        System.Console.WriteLine(i);
    }
    if(i>n) i=0;
    i++;
}
