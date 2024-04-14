using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pralka_fasady_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        class Washing 
        {
            public void wash() { }
        }
        class Rinsing
        {
            public void rinse() { }
        }
        class Spinning
        {
            public void spin() { }
        }
        class WashingMachine
        {
            Washing w;
            Rinsing r;
            Spinning s;
            public void inicjujpraniepralko(Washing w, Rinsing r,Spinning s)
            {
                this.w = w;
                this.r = r;
                this.s = s;
            }

            public void startwashing() { }
        }
        class Client 
        {
            WashingMachine wm;
            public void setwashingmachine(WashingMachine wm) 
            {
                this.wm = wm;
            }
        }

    }
}
