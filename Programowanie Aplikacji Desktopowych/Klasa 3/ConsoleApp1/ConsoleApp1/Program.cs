using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public string toBinary(int input)
            {
                string output = "";
                while (input > 0)
                {
                    output += input % 2;
                    input /= 2;
                }
                return output;
            }
            
        }
    }
}
