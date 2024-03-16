
using System;
// Niech n będzie nieujemną liczbą całkowitą, której najbardziej znacząca cyfra w zapisie
// dziesiętnym jest większa od 0 i mniejsza od 9. Cyfrowym dopełnieniem liczby n nazywamy
// liczbę całkowitą d, której zapis dziesiętny otrzymujemy z zapisu dziesiętnego liczby n przez
// zamianę każdej cyfry tego zapisu na cyfrę, która jest jej uzupełnieniem do 9. 





// string nowy = "";
// int x = Convert.ToInt32(Console.ReadLine());
// while(x>0)
// {
//     nowy += 9 - x%10;
//     x /= 10;
// }
// char[] charArray = nowy.ToCharArray();
// Array.Reverse(charArray);
// nowy = new string(charArray);
// int d = Convert.ToInt32(nowy); 
// System.Console.WriteLine(d);



// int a = 10000;
// int b = 0;
// int max_n = 0;
// int min_n = 0;
// for(int i = 1000; i < 9000; i++)
// {
//     int d = 9999-i;
//     int z = i - d;  
//     z = Math.Abs(z);
//     if (z>b)
//     {
//         b = z;
//         max_n = i;
//     }
//     if (z<a)
//     {
//         a = z;
//         min_n = i;
//     }
// }
// System.Console.WriteLine(min_n);
// System.Console.WriteLine(max_n);