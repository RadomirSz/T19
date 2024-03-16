using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02.NewFolder1
{
    internal class Person
    {
        //Publiczne statyczne pole, które przechowuje liczbę obiektów klasy Person
        public static int Counter = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }

        // konstruktor statyczny jest wywoływany automatycznie, aby zainicjować klasę przed utworzeniem pierwszej instalacji. Jest wywoływany tylko 1 raz, przed pierwszym użyciem typu. Konstruktor statyczny nie może mieć paramentrów ani modyfikatorów dostępu. Służy do inicjowania pól statycznych lub wykonywania innych operacji statycznych. ()

        static Person()
        {
            //Console.WriteLine("statyczny konstruktor klasy person");
            Counter++;
        }

        // Konstruktor domyślny jest bezparametrowym. Jeśli klasa nie ma żadnego konstruktora parametrycznego, to konstruktor domyślny jest wywoływany przy tworzeniu obiektu. Inicjuje on wszystkie pola do ich watrości domyślnych. Jeśli zdefiniujemy jakiś konstruktor paramentryczny, to nie otrzymamy automatycznie konstruktora domyślnego i musimy go samodzielnie zadeklarować.

        // Dodać konstuktor domyślny
        public Person() 
        {
            Console.WriteLine("konstruktor domyślny");
            Name = "Nieznane";
            Surname = "Nieznane";
            Counter++;
        }
        //Kostruktor parametryczny ma co najmniej 1 parametr.Słyży do inicjowania pól obiektu zgodnie z wartościami podanymi przy tworzeniu obiektu.Możemy mieć wiele konstruktorów parametrycznych, o ile różnią się liczbą lub typem paramemetrów.

        public Person(string name)
        {
            Console.WriteLine("konstruktor parametryczny z jednym parametrem");
            Name = name;
            Counter++;
        }

        //konstruktor parametryczny z 2 parametrami

        public Person(string name, string surname) 
        {
            Console.WriteLine("konstruktor parametryczny z 2 parametrami");
            Name = name;
            Surname = surname;
            Counter++;
        }

        //konstruktor 4 parametry
        // this służy do wywołania innego konstruktora tej samej klasy, czyli konstruktora parametrycznego z 3 parametrami. Dzięki temu konstruktor z 4 parametrami nie musi inicjowaniać pól Name, Surname, Agem a może skupić się na dodaniu pola Height. Hest to sposób na uniknięcie powtarzanie kodu i zapewnienie spójności danych.
        public Person(string name , string surname , int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Counter++;
        }

        //this 

        public Person(string name, string surname, int age, float height) : this(name,surname,age)
        {
            Height = height;
        }
        public string GetData()
        {
            return $"Imię:{Name} {Surname}, wiek: {Age}"; 
        }


    }
}
