using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_03
{
    public class Ada : IAda, IDao
    {
        public const int limit = 10;
        public int dlugosc(string t)
        {
            if (t.Length > limit) throw new ArgumentException();
            return limit - t.Length;
        }
    }
}
