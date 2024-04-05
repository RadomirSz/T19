using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    internal class Program
    {
        public abstract class stanowiska 
        {
            public string nazwaStanowiska;
            public stanowiska(string nazwa) { nazwaStanowiska = nazwa; }
        }
        class zarządca : stanowiska{ }
        class prezes : zarządca { }

        static void Main(string[] args)
        {
        }
    }
}
