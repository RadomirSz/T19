//zad15 (z kp) / 1 zad na spr
float iloczyn = 1;
float mianownik = 1;
float licznik = 3;
int n = int.Parse(Console.ReadLine());
for (int i = 0; i<n; i++)
{
    iloczyn *= licznik / mianownik;
    mianownik = (mianownik * 2) + 1;
    licznik++;
}
Console.WriteLine(iloczyn);


//zad2 
int a = 0;
int b = 1;
int suma = 0;
int n = int.Parse(Console.ReadLine());
for (int j = 0; j < n; j++)
{
    int temp = a;
    a = b;
    b = a + temp;
    suma += b;
    temp = 0;
}
Console.WriteLine(suma);
