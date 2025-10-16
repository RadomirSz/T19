using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _16_10
{
    internal class ZniżkaKwotowa : IZniżkaStrategia
    {
        public int obliczZniżkę(int k, int x)
        {
            return k - x;
        }
    }

    internal class ZniżkaProcentowa : IZniżkaStrategia
    {
        public int obliczZniżkę(int k, int x)
        {
            return (k * (100 - x)) / 100;
        }
    }
}