using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umlNaKod
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }

    public abstract class Component 
    {
        public abstract void operation();
    }
    class Leaf : Component
    {
        public override void operation() { }
    }
    class Composite : Component 
    {
        public override void operation() { }
        public void add() { }
        public void remove() { }
        public void getChild() { }

        public List<Component> lista = new List<Component>();
    }
}