using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja_1
{
    internal class Program
    {
        public class Shape
        {
            public virtual float CalculateArea() { return 0; }
            public virtual float CalculatePerimeter() {  return 0; }
        }

        public class Rectangle : Shape
        {
            private float width;
            private float height;
            public void SetDimension(float w, float h)
            {  
                width = w; 
                height = h; 
            }

            public override float CalculateArea() 
            {
                //return base.CalculateArea()
                return width * height;
            }
            public override float CalculatePerimeter()
            {
                return 2 * (width + height);
            }
        }

        public class Circle : Shape 
        { 
            private float radius;

            public Circle(float radius)
            {
                this.radius = radius;
            }
            public void setRadius(float r) { radius = r; }

            public override float CalculateArea() { return (float)Math.Round((Math.PI * radius *radius),2); }
            public override float CalculatePerimeter() { return (float)(2 * Math.PI * radius); }
        
        }

        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("1.Prostokąt");
                Console.WriteLine("2.Koło");
                Console.WriteLine("3.Trójkąt");
                Console.WriteLine("4.Trapez");
                Console.WriteLine("5.Kula");
                Console.WriteLine("6.Wyjście");
                Console.WriteLine("Wybieraj: ");
                int choice = int.Parse(Console.ReadLine());

                switch(choice) 
                {
                    case 1:
                        Rectangle rectangle = new Rectangle();
                        Console.WriteLine("Podaj szerokość:");
                        float rectWidth = float.Parse(Console.ReadLine());
                        Console.WriteLine("podaj wysokosc:");
                        float rectHeight = float.Parse(Console.ReadLine());
                        rectangle.SetDimension(rectWidth, rectHeight);
                        Console.WriteLine("powierzchnia: " + rectangle.CalculateArea() + 
                            "\nobwód: " + rectangle.CalculatePerimeter());
                        break;
                    case 2:
                        Console.WriteLine("daj średnice:");
                        float r = float.Parse(Console.ReadLine());
                        Circle circle = new Circle(r);
                        Console.WriteLine("powierzchnia: " + circle.CalculateArea() +
                            "\nobwód: " +circle.CalculatePerimeter());
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("nieprawidłowy wybór spróbuj ponownie");
                        break;
                }
            }
        }
    }
}
