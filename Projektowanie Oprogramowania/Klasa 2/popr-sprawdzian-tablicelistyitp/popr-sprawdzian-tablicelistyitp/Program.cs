

int[] T = new int[30];
Random r = new Random();
for (int i = 0; i < 30; i++)
{
    T[i] = r.Next(100,1000);
}
int suma = T[0];
int pierwsza = 0;
int ostatnia = 0;
int temppierwsza = 0;
int tempostatnia = 0;

int dlugosc = 1;
int tempdlugosc = 1;
for (int i = 1; i < 30; i++)
{
    if (T[i] > T[i - 1])
    {
        tempdlugosc++;
        tempostatnia = T[i];
        temppierwsza = T[i - tempdlugosc];
    }
    else 
    {
        pierwsza = temppierwsza;
        ostatnia = tempostatnia;
        dlugosc = tempdlugosc;
    }
}



foreach (var item in T)
{
    Console.WriteLine(item);
}
