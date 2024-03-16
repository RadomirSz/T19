namespace _10._2_16_01;

class Program
{   
    class person
    {
        public string imieOsoby{ get; set; }
        public string NazwiskoOsoby{ get; set;}
        public float wzrost{ get; set;}
        public float waga{ get; set;}

    }
    static void Main()
    {
        person nowak = new person();
        nowak.imieOsoby = "Bartosz";
        nowak.waga = 97.3F;
        System.Console.WriteLine(nowak.imieOsoby);
    }
}
