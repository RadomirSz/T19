using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzęta_zarządzanie.Properties
{
    public enum Kind // definicja typu anum Kind/rodzaj
    {
        Ptak,
        Ryba,
        Gad,
        Płaz,
        Ssak
    }
    internal class Animal
    {
        //właściwości
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool isMammal { get; set; }
        public Kind Kind { get; set; }

        public Animal(string name)
        {
            Name = name;
            BirthDate = DateTime.MinValue; // domyślna data urodzenia
            isMammal = true;
            Kind = Kind.Ssak;
        }
        public Animal(string name, DateTime birthDate) : this(name)
        {
            BirthDate = birthDate;
        }
        public Animal(string name, DateTime BirthDate, bool ismammal) : this(name, BirthDate)
        {
            isMammal = ismammal;
        }

        public Animal(string name, DateTime birthDate, bool isMammal, Kind kind) : this(name,birthDate,isMammal)
        {
            Kind = kind;
        }

        public string Describe()
        {
            string description = $"Nazwa zwierzęcia: {Name}. Data urodzenia: {BirthDate.ToShortDateString()}r. ";

            if (isMammal) description += "Zwierze jest ssakiem. ";
            else description += "Zwierze nie jest ssakiem. ";
            description += "Rodzaj zwierzęcia: " + Kind;
            return description;
        }

        public void ShowAge()
        {
            //obliczenie wieku (w latach)
            int age = DateTime.Now.Year - BirthDate.Year;
            Console.WriteLine($"Wiek zwierzecia wynosi {age} lat.");
        }

    }
}
