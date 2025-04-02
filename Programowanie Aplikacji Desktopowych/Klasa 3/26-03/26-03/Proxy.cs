using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_03
{
    internal class Proxy
    {
        IAda ada = new Ada();

        public string TekstDlug(string t)
        {
            return "Zostało: " + ada.dlugosc(t);
        }
    }
}
