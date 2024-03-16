//zad1
/*
int n = int.Parse(Console.ReadLine()); 
for (int i = 0; i < n; i++) 
{
    Console.Write(Math.Pow(i, 3) + 3 + " "); 
}
*/
//zad2
/*
for (int i = 105; i < 1000; i = i + 15)
{ 
 Console.WriteLine(i+" ");
}
*/
//zad3
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if (n % i== 0)
        {
            Console.Write(i + " ");
        }
}
