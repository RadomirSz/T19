using System;
namespace _7_11;

class Program
{
    static void Main(string[] args)
    {
        /*
        int[] T = {1,2,3};
        System.Console.WriteLine(T[0] +" "+ T[T.Length - 1] );

        int[] T2 = new int[5];

        T2[1] = 1;
        T2[2] = 2;
        T2[3] = 3;
        T2[0] = 4;
        T2[4] = 5;

        foreach (int i in T2)
        {
        System.Console.WriteLine(i);    
        }
        */
        
        // int[] T3 = new int[5];
        // for(int i = 0;i<5;i++)
        // {
        //     bool done = false;
        //     do
        //     {
        //         try
        //         {
        //             System.Console.WriteLine("daj liczbę całkowitą");
        //             T3[i] = Convert.ToInt32(Console.ReadLine());    
        //             done = true;
        //         }
        //         catch (Exception ex)
        //         {
        //             Console.ForegroundColor = ConsoleColor.Red;
        //             System.Console.WriteLine(ex.Message);
        //             Console.ResetColor();
        //         }
                
        //     }while(!done);
        // }
        // int suma=0;
        // foreach (int i in T3)
        // {
        //  suma += i;   
        // }
        // System.Console.WriteLine(suma);


        // Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy, a następnie wyświetla sumę wszystkich 
        // elementów tablicy.
        // Użyj języka programowania C# i środowiska Visual Studio.
        // Zadeklaruj tablicę o rozmiarze 5 i nazwij ją numbers.
        // Użyj pętli for, aby pobrać od użytkownika 5 liczb całkowitych i zapisać je w tablicy numbers.
        // Wyświetl na ekranie komunikat, który prosi użytkownika o podanie kolejnej liczby całkowitej i użyj metody GetIntegerFromUser(), 
        // aby ją pobrać i zweryfikować.
        // Zdefiniuj metodę GetIntegerFromUser(), która przyjmuje od użytkownika liczbę całkowitą i zwraca ją. Jeśli użytkownik wprowadzi 
        // niepoprawną wartość, metoda wyświetli stosowny komunikat i poprosi o ponowne wprowadzenie liczby.
        // Użyj metody int.TryParse(), aby sprawdzić, czy wprowadzona wartość jest poprawną liczbą całkowitą i przypisać ją do zmiennej input.
        // Zdefiniuj metodę CalculateSum(int[] numbers), która przyjmuje tablicę liczb całkowitych i zwraca ich sumę.
        // Użyj pętli foreach, aby dodać do sumy każdy element tablicy numbers i zwrócić sumę.
        // Wywołaj metodę CalculateSum(numbers) i przypisz jej wynik do zmiennej sum.
        // Wyświetl na ekranie komunikat, który pokazuje sumę podanych liczb.


        int[] numbers = new int[5];
        for(int i = 0;i<numbers.Length;i++)
        {
            numbers[i] = GetIntegerFromUser();
        }
        System.Console.WriteLine(CalculateSum(numbers));
        System.Console.WriteLine(numbers.Sum());

    
    }
    static int GetIntegerFromUser()
    {
        System.Console.WriteLine("daj liczbę całkowitą");
        while(true)
        {
            if(int.TryParse(Console.ReadLine(), out int number))
            {
                return number;
            }
            System.Console.WriteLine("Niepoprawna liczba!");
        }
    }
    static int CalculateSum(int[] Table)
    {
        int suma = 0;
        foreach (int i in Table)
        {
         suma += i;   
        }
        return suma;
    }
}
