using System.Collections.Generic;
namespace _9_12_12;

class Program
{
    static void Main(string[] args)
    {
        /*
        #region lekcja
        Dictionary<int,string> people = new Dictionary<int,string>();
        people.Add(1,"zosia1");
        people.Add(2,"zosia2");
        people.Add(3,"zosia3");
        people.Add(4,"zosia4");
        foreach (var item in people)
        {
            System.Console.WriteLine($"{item.Value} , {item.Key}");
        }

        Dictionary<string,string> capital = new Dictionary<string,string>();

        capital = new Dictionary<string,string>
        {
            {"Polska", "Warszawa"},
            {"Niemcy", "Berlin"},
            {"Belgia", "Bruksela"},
            {"Czechy", "Praga"}
        };

        foreach (var item in capital)
        {
            System.Console.WriteLine($"{item.Key}, {item.Value}");
        }


        Dictionary<string,string> phones = new Dictionary<string,string>();
        phones.Add("3465098906","Tomasz");
        phones.Add("3123489090","Tom12asz");
        phones.Add("3461234980","To123masz");
        phones.Add("3461234890","Tom1234asz");

        foreach (var item in phones)
        {
            System.Console.WriteLine("nr tele: {0} , imie: {1}", item.Key , item.Value);
        }
        #endregion
        */



        #region zadanie
        /*
        Napisz funkcję, która przyjmuje jako argument listę liczb całkowitych i zwraca słownik, w którym kluczem jest 
        liczba, a wartością jest jej częstotliwość występowania na liście.
        Jeśli lista jest pusta lub null, funkcja powinna zwrócić pusty słownik.
        Przykład: dla listy [1, 2, 3, 2, 4, 1, 5, 2] funkcja powinna zwrócić słownik {1: 2, 2: 3, 3: 1, 4: 1, 5: 1}.
        
        Napisz program, który wczytuje od użytkownika ciąg znaków, próbuje przekonwertować go na liczbę całkowitą za 
        pomocą metody TryParse, a następnie wyświetla wynik na konsoli.
        Jeśli konwersja się powiedzie, program powinien wyświetlić liczbę i informację, że jest to poprawna liczba całkowita.
        Jeśli konwersja się nie powiedzie, program powinien wyświetlić informację, że podany ciąg znaków nie jest 
        poprawną liczbą całkowitą.
        Przykład: dla ciągu znaków “123” program powinien wyświetlić “123 jest poprawną liczbą całkowitą”.
        Dla ciągu znaków “abc” program powinien wyświetlić “abc nie jest poprawną liczbą całkowitą”.
        */

        #endregion
        int[] T = new int[9]{1,2,3,4,5,3,3,4,5};
        Dictionary<int,int> liczbunie = naslownik(T);
        
        foreach (var i in liczbunie)
        {
            System.Console.WriteLine(i);
        }
    }

    static Dictionary<int,int> naslownik(int[] T)
    {
        Dictionary<int,int> liczby = new Dictionary<int,int>();
        for (int i = 0; i < T.Length() ; i++)
        {
            if(!liczby.ContainsKey(T[i])) 
            {
                int count = 1;
                for (int j = i; j < T.Length(); j++)
                {
                    if(T[j] == T[i]) count++;
                }
                liczby.Add(T[i], count);
            }
        }
        return liczby;
    }
}