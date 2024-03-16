using System.Drawing;
using System;
namespace _10_2_16_01
{
    class Program
    {
        static void Main()
        {
            Person osoba1 = new Person();
            
            osoba1.namesetter("Bartosz");
            osoba1.NazwiskoOsoby = "Nowak";
            
            System.Console.WriteLine("nazwisko: " + osoba1.getnazwisko());

            Student s1 = new Student();
            s1.StudentNumber = "1234";

            System.Console.WriteLine("numer indeksu ucznia: " + s1.StudentNumber);

        
            Teacher t1 = new Teacher();

            t1.Subjects = new List<string> {"matematyka","historia","informatyka"};

            System.Console.WriteLine(t1.GetSubjects());
            System.Console.WriteLine();


            osoba1.Address = new Address();
            osoba1.Address.City = "Poznań";
            osoba1.Address.Street = "Polna";
            osoba1.Address.HouseNumber = "10/6";
            osoba1.Address.PostalCode = "67-364";

            System.Console.WriteLine(osoba1.Address.getAddress());
            System.Console.WriteLine();

            #region dejt-tajmy
            osoba1.DateOfBirth = DateTime.Now;
            System.Console.WriteLine("Data i czas: " + osoba1.DateOfBirth);
            
            
            osoba1.DateOfBirth = new DateTime();
            System.Console.WriteLine("Data i czas: " + osoba1.DateOfBirth);
                        
            
            osoba1.DateOfBirth = new DateTime(2000,3,20);
            System.Console.WriteLine("Data i czas: " + osoba1.DateOfBirth);
            System.Console.WriteLine();

            osoba1.DateOfBirth = new DateTime(2000,3,20);
            System.Console.WriteLine("Data (ToShortDateString): " + osoba1.DateOfBirth.ToShortDateString());

           
            // osoba1.DateOfBirth = new DateTime(2000,3,20);
            // System.Console.WriteLine("czas (ToShortTimeString): " + osoba1.DateOfBirth.ToShortTimeString());


            osoba1.DateOfBirth = new DateTime(2000,3,20,12,13,20);
            System.Console.WriteLine("czas (ToShortTimeString): " + osoba1.DateOfBirth.ToShortTimeString());

            
            osoba1.DateOfBirth = new DateTime(2000,3,20,12,13,20);
            System.Console.WriteLine("czas (ToLongTimeString): " + osoba1.DateOfBirth.ToLongTimeString());
            
            
            osoba1.DateOfBirth = new DateTime(2000,3,20,12,13,20);
            System.Console.WriteLine("czas: (ToLongDateString)" + osoba1.DateOfBirth.ToLongDateString());
            #endregion
        }
    }
}