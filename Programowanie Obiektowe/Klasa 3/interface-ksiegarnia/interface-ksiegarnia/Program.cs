using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy_3
{
    class Book : IComparable<Book>, IEquatable<Book>
    {
        public string title;
        public string author;
        public int yearOfPublication;
        public double price;

        public Book(string title, string author, int yearOfPublication, double price)
        {
            this.title = title;
            this.author = author;
            this.yearOfPublication = yearOfPublication;
            this.price = price;
        }

        public int CompareTo(Book other)
        {
            if (other == null) return 1;
            return price.CompareTo(other.price);
        }

        public bool Equals(Book other)
        {
            if (this == other) return true;
            return false;
        }

        // Nadpisanie domyślnej metody ToString() 
        public override string ToString()
        {
            return $"{title}, {author}, {yearOfPublication}, {price}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            books.Add(new Book("Hobbit", "Nowak", 1937, 45.99));
            books.Add(new Book("Hobbit2", "Pawlak", 2000, 155.99));
            books.Add(new Book("Hobbit3", "Arbuz", 2000, 5.99));
            books.Add(new Book("Hobbit4", "Arbuz", 1948, 5.99));
            books.Add(new Book("Hobbit4", "AArbuz", 1948, 5.99));

            Console.WriteLine("Lista książek:");
            foreach (Book book in books)
            {
                Console.WriteLine(book);    // Console.WriteLine(book.ToString()) ten zapis oznacza to samo, ponieważ ToString() uruchamia się domyślnie
            }

            Console.WriteLine("\nLista posortowana domyślnie (według ceny)");
            books.Sort();

            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("\nSortowanie według daty publikacji");
            var sortedByYear = books.OrderBy(b => b.yearOfPublication);
            foreach (Book book in sortedByYear)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("\nSortowanie według autora");
            var sortedByAuthor = books.OrderBy(b => b.author);
            foreach (Book book in sortedByAuthor)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("\nSortowanie według ceny nierosnąco a następnie według roku publickacji od najstarzej książki");
            var sortedByPriceAndYear = books.OrderByDescending(b => b.price).ThenBy(b => b.yearOfPublication); // ThenBy() przeprowadza dodatkowe sortowanie według drugiego warunku (yearOfPublication) 
            foreach (Book book in sortedByPriceAndYear)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("\nsortowanie, które najpierw sortuje książki według ceny malejąco, następnie według roku publikacji rosnąco, a na końcu według autora alfabetycznie.");
            var sortedByPriceDescendingThenYearAndAuthor = books.OrderByDescending(b => b.price).ThenBy(b => b.yearOfPublication).ThenBy(b => b.author);
            foreach (Book book in sortedByPriceDescendingThenYearAndAuthor)
            {
                Console.WriteLine(book.ToString());
            }



            Console.ReadKey();
        }
    }
}