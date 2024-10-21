using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_interface
{
    public interface IAnimal
    {
        void makesound();
        void Eat();
    }
    public abstract class Animal : IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Eat(){
            Console.WriteLine("omnomnomnom");
        }

        public virtual void makesound() {}
    }

    public class dog : Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override void makesound() 
        {
            Console.WriteLine("Hau!");
        }
        public dog(string name, int age) : base(name, age) { }
    }
    public class cat : Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override void makesound()
        {
            Console.WriteLine("Miau!");
        }
        public cat(string name, int age) : base(name,age){}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            dog dog = new dog("burek", 3);
            cat cat = new cat("puss", 1);

            dog.Eat();
            dog.makesound();
            
            cat.Eat();
            cat.makesound();
            

            Console.ReadKey();
            Console.Clear();
            

            List<Animal> animals = new List <Animal>();
            animals.Add(dog);
            animals.Add(cat);
            Console.WriteLine("z listy: ");
            foreach (var item in animals)
            {
                item.Eat();
                item.makesound();
            }
            Console.ReadKey();
        }
    }


}





/*
 
Zdefiniowanie interfejsu IAnimal:
Utwórz interfejs IAnimal z dwoma metodami: MakeSound() i Eat().
Utworzenie klasy abstrakcyjnej Animal:
Klasa Animal implementuje interfejs IAnimal.
Dodaj właściwości Name (string) i Age (int).
Utwórz konstruktor przyjmujący parametry name i age oraz przypisujący je do odpowiednich właściwości.
Zaimplementuj metodę Eat(), która wyświetla komunikat w konsoli.
Zdefiniuj metodę abstrakcyjną MakeSound().

Implementacja klasy Dog:
Klasa Dog dziedziczy po klasie Animal.
Utwórz konstruktor przyjmujący parametry name i age oraz przekazujący je do konstruktora bazowego.
Zaimplementuj metodę MakeSound(), która wyświetla komunikat “Hau!”.

Implementacja klasy Cat:
Klasa Cat dziedziczy po klasie Animal.
Utwórz konstruktor przyjmujący parametry name i age oraz przekazujący je do konstruktora bazowego.
Zaimplementuj metodę MakeSound(), która wyświetla komunikat “Miau!”.

Utworzenie klasy Program z metodą Main:
Utwórz obiekty Dog i Cat z odpowiednimi parametrami.
Wywołaj metody MakeSound() i Eat() dla każdego z obiektów.
Wyczyść konsolę za pomocą Console.Clear().
Utwórz listę animals zawierającą obiekty Dog i Cat.
Iteruj przez listę animals, wywołując metody MakeSound() i Eat() dla każdego obiektu.
Zatrzymaj program, oczekując na naciśnięcie klawisza za pomocą Console.ReadKey(). 

 */