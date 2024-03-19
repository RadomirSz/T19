namespace _10_2_16_01
{
    internal class Person
    {
        public string? imieOsoby{ get; private set; }
        public string? NazwiskoOsoby{ private get; set; }
        public float wzrost{ get; set; }
        public float waga{ get; set; }

        public Address Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        
        public void namesetter(string imie)
        {
            imieOsoby = imie;
        }
        public string getnazwisko()
        {
            return NazwiskoOsoby;
        }
    }
}