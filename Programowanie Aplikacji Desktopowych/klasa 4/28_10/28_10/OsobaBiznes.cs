using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_10
{
    class OsobaBiznes
    {
        OsobaContext Context;
        public OsobaBiznes()
        {
            Context = new OsobaContext();
        }

        public List<Osoba> pobierzOsoby()
        {
            return Context.Osoby.ToList();
        }
    }
}
