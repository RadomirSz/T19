using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminProbnyKonsolowa
{
    public class Student
    {
        public Student(int id, string name, string surname, float grade)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Grade = grade;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public float Grade { get; set; }
    }
}
