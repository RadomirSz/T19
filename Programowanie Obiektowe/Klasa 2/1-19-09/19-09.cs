using System;

namespace _19._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // komentarz jednoliniowy
            /*
             wielo
            liniowy komentarz
             */
            System.Console.WriteLine("cześć");
            System.Console.Write("bu: ");
            System.Console.Write("cześć");
            System.Console.Clear();


            /*
             int 16,32,64
             byte 0 do 255
             sbyte -128 do 127
             short -32768 do 32767
             ushort 0 - 65535
             int  - 2 147 483 648 do 2 147 483 648
             uint 0 - 4 294 967 295 (32 bity => 4 bajty)
             long (64 bity => 8 bajty)
             ulong 0 - 18 446 744 
             bool true/false

             float
             double
             */

            int i; // deklaracja zmiennej
            int i1 = 10; // deklracja z jednoczesną inicjalizacją zmiennej

            Console.WriteLine("zmienna i1: " + i1);

            System.Int32 i2 = 20;

            Console.WriteLine($"i1: {i1}, i2: {i2}");

            byte a = 100;
            sbyte b = -100;
            short c = -20000;
                        

            int i3 = 10;            //to
            Int32 i4 = 10;          //to
            System.Int32 i5 = 10;   //samo

            long l = -10L;    // suffix L
            ulong ul = 10ul;  //suffix UL
            System.Console.WriteLine($"zmienna l: {l}, zmienna ul: {ul}");

            float f = 10.5F;  //suffix F
            
            //zapis systemów liczbowych
            
            // system binarny
            System.Console.WriteLine(0b1011); //11

            //oktalny
            System.Console.WriteLine(011);  //11
            int io = Convert.ToInt32("11",8);
            System.Console.WriteLine(io);


            //heksadecymalny
            System.Console.WriteLine(0xA1);

            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.WriteLine("♥");
            System.Console.WriteLine("\u2665");
            System.Console.OutputEncoding = System.Text.Encoding.Default;

            char letter = 'a';
            System.Console.WriteLine(letter);
            char letter2 = (char)97;
            System.Console.WriteLine(letter2);
            

            System.Console.WriteLine("\x03c0"+"r"+"\x00B2");
            System.Console.WriteLine("πr²");

            Console.ReadKey();

        }
    }
}
