using Internal;
using System;
namespace _31_10;

class Program
{
    /*
    static void Main(string[] args)
    {
        //Napisz program w C#, który wczytuje liczbę całkowitą od użytkownika i oblicza jej pierwiastek kwadratowy.
        //Jeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
        //Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby. 
        //Program powinien działać w pętli, dopóki użytkownik nie wpisze q. Użyj instrukcji try-catch-finally do obsługi wyjątków.
    bool powtorz = true;
    do 
    {
        try
        {
            System.Console.WriteLine("Podaj liczbę do zpierwiastkowania lub \"q\" żeby zakończyć ");
            string input = Console.ReadLine();

            if(input == "q"){
                powtorz = false;
            }
            else if(Convert.ToInt64(input) <= 0) throw new ArgumentOutOfRangeException(); 
            else
            {
                System.Console.WriteLine(Math.Sqrt(Convert.ToUInt64(input)));
            }

        }
        catch(ArgumentOutOfRangeException)
        {
            errorcolor("Liczba nie może być ujemna lub być zerem");
        }
        catch(OverflowException)
        {
            errorcolor("Zbyt duża liczba");
        }
        catch(FormatException)
        {
            errorcolor("Podano nieprawidłowe dane");
        }
        catch(Exception ex)
        {
            errorcolor($"{ex.Message}");
        }
        //finally{System.Console.WriteLine("w bolierze nie ma żadnej bomby");}
    }
    while(powtorz);
    }
    */






    static void Main(string[] args)
    {
        /*Napisz program w C#, który wczytuje od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. 
        Następnie program prosi użytkownika o podanie indeksu tablicy i wyświetla liczbę znajdującą się pod tym indeksem. 
        Jeśli użytkownik wprowadzi indeks spoza zakresu tablicy, program powinien zgłosić wyjątek ArgumentOutOfRangeException
        i wyświetlić odpowiedni komunikat. Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek 
        FormatException i poprosić o ponowne wprowadzenie danych. Program powinien działać w pętli, dopóki użytkownik 
        nie wpisze q. Użyj instrukcji try-catch do obsługi wyjątkówJeśli liczba jest ujemna, program powinien zgłosić 
        wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
        Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o 
        ponowne wprowadzenie liczby. */
        int[] T = new int[5]{0,0,0,0,0};
        
        do{

            try
            {
                    for (int i = 0; i < length; i++)
                {
                    System.Console.WriteLine($"podaj {i+1} liczbę większą od zera do tabeli:");    
                    T[i] = Convert.ToInt32(Console.ReadLine());
                    if(T[i] <= 0) throw new ArgumentOutOfRangeException();
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                errorcolor("zbyt mała lub zbyt duża liczba");
            }
            catch(FormatException)
            {
                errorcolor("niepoprawny format danych");
            }
        }while(!isCorrect);
            

        int index = 0;
        string input;
        do
        {
            System.Console.WriteLine("wprowadź indeks z tablicy lub \"q\" aby zakończyć program");
            input = Console.ReadLine();
            if(input =="q") break;

            try
            {
                index = Convert.ToInt32(input):
                if(index > T.length - 1 || index < 0) throw new OverFlowException("błont");
            }
            catch(FormatException)
            {
                errorcolor("zły format danych");
            }
            catch(IndexOutOfRangeException)
            {
                errorcolor("zły indeks");
            }

        } while ();
        

    }

    static void errorcolor(string komentarz)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine($"{komentarz}");
        Console.ResetColor();
    }
}
