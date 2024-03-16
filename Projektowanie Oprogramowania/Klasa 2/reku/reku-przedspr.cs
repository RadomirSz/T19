using System;
//Ciąg: 1, 2, 3, 4, 5, 6, 7, 8...
// int reku1(int n)
//{
//    if(n == 1) return 1;
//    return reku1(n-1) + 1;
//}
//for (int i = 1; i < 6; i++)
//{
//    System.Console.WriteLine(reku1(i));
//}
//Ciąg: 2, 4, 16, 256, 65536, ... tylko 5 wyrazów!
//int reku2(int n)
//{
//    if(n == 1) return 2;
//    return reku2(n-1) * reku2(n-1);
//}
//for (int i = 1; i < 6; i++)
//{
//    System.Console.WriteLine(reku2(i));
//}

//Ciąg: 0, 1, 2, -1, 4, -3, 6, -5, 8...

//Ciąg 1, 2, 1.5, 1.75, 1.625, 1.6875

//Ciąg 1, 2, 4, 4, 16, 6, 36, 8, 64, ...

//Ciąg 1, 2, 3, 1, -2, -3, -1, 2, 3...
// int reku69(int n)
// {
//     if(n==1) return 1;
//     if(n==2) return 2;
//     if(n==3) return 3;
//     return reku69(n-1) - reku69(n-2);
// }
// for (int i = 1; i < 10; i++)
// {
//     System.Console.WriteLine(reku69(i));
// }
//Ciąg: 5, 10, 20, 40, 80, ...
// int reku70(int n)
// {
//     if(n == 1) return 5;
//     return reku70(n-1)*2;
// }
// for (int i = 1; i < 10; i++)
// {
//     System.Console.WriteLine(reku70(i));
// }


// a * 2 + (b-c)

// int reku3(int n)
// {
//     if(n == 1) return 1;
//     if(n == 2) return 2;
//     if(n == 3) return 3;
//     return reku3(n-3) * 2 + (reku3(n-2) - reku3(n-1));
// }
// for (int i = 1; i < 20; i++)
// {
//     System.Console.WriteLine(reku3(i));
// }

// nwd nww

// int reku31(int n,int n2)
// {
//     if (n2 != 0) return reku31(n2, n % n2);
//     return n;
// }
// Console.WriteLine(reku31(21,9));


// int reku32(int n, int n2)
// {
//     if (n < n2) return reku32(n , n2-n);
//     if (n > n2) return reku32(n-n2 , n2);
//     return n;
// }
// Console.WriteLine(reku32(16,20));

