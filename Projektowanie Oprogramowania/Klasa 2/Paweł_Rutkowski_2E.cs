// Paweł Rutkowski 2E
// Zadanie -1
int Nww(int a, int b)
{
    while(a!=b)
    {
        if(a>b) a-=b;
        if(b>a) b-=a;
    }
    return b;
}
int Nwd(int a, int b)
{
    return a*b/Nww(a,b);
}

bool CzyZlozona(int a)
{
    bool flag = false;
    for(int i = 1;i<a;i++)
    {
        if(a == 1 || a == 2)break;
        if(a%i==0)flag = true;
    }
    return flag;
}


bool Ibrahim(int a, int b)
{
    return CzyZlozona(Nwd(a,b));
}
Console.Write("Zadanie -1\nPodaj a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Podaj b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Para liczb {Ibrahim(a,b)} jest parą liczb Ibrachima-Pasza");
// 0
Console.WriteLine("Zadanie 0:");
for(int i = 20;i<=50;i++)
{
    for(int j = 20;j<=50;j++)
    {
        if(Ibrahim(i,j)){ Console.WriteLine($"{i} {j}");}
    }
}

// Zadanie 1
int n = 20;
int[,] M = new int[n,n];
Random random = new Random();

// Generowanie macierzy
for(int i = 0;i<n;i++)
{
    for(int j = 0;j<n;j++)
    {
        
        if(random.Next(0,9) == 1 || random.Next(0,9) == 2 || random.Next(0,9) == 3 || random.Next(0,9) == 4) M[i,j] = 0;

        if(random.Next(0,9) == 5 || random.Next(0,9) == 6) M[i,j] = 1;

        if(random.Next(0,9) == 7 || random.Next(0,9) == 8) M[i,j] = 2;
        
        if(random.Next(0,9) == 9)
        {
            if(random.Next(0,1) == 0) M[i,j] = 3;
            else M[i,j] = 4;
        }    
    }
}
// Wyświetlanie
for(int i = 0;i<n;i++)
{
    for(int j = 0;j<n;j++)
    {
        Console.Write($"{M[i,j]} ");
    }
    Console.WriteLine();
}
// Sprawdzanie warunku Kołeja
for(int i = 0;i<n;i++)
{
    for(int j = 0;j<n;j++)
    { 
       int sum = 0;
       System.Console.WriteLine($"{i} {j}");
        if (j == n)
        {
            if(i == 0)
            {
                sum = M[i+1,j] + M[i+1,j-1] + M[i,j-1];
            }
            else if(i == n)
            {
                sum = M[i-1,j] + M[i-1,j-1] + M[i,j-1];
            }
            else
            {
                sum = M[i+1,j] + M[i-1,j] + M[i+1,j-1] + M[i-1,j-1] + M[i,j-1];
            }
            if(M[i,j] == sum) Console.WriteLine($"Komórka [{i},{j}] spełnia warunek Kołeja");
        }

        else if(j == 0)
        {
            if(i == 0)
            {
                sum = M[i+1,j] + M[i+1,j+1] + M[i,j+1];
            }
            else if(i == n)
            {
                sum = M[i-1,j] + M[i-1,j+1] + M[i,j+1];
            }
            else
            {
                sum = M[i+1,j] + M[i-1,j] + M[i+1,j+1] + M[i-1,j+1] + M[i,j+1];
            }
            if(M[i,j] == sum) Console.WriteLine($"Komórka [{i},{j}] spełnia warunek Kołeja");
        }
       else
       {
            sum = M[i+1,j] + M[i-1,j] + M[i+1,j-1] + M[i-1,j-1] + M[i,j-1] + M[i+1,j+1] + M[i-1,j+1] + M[i,j+1];
            if(M[i,j] == sum) Console.WriteLine($"Komórka [{i},{j}] spełnia warunek Kołeja");
       }
    }
}

// zadanie 4, tak jak widać