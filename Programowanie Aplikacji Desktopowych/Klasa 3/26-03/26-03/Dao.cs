using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_03
{
    public class Dao : IDao
    {
        public int dlugosc(string t)
        {
            return t.Length;
        }
    }
}
