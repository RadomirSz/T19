using System;
using System.Collections;
using System.Collections.Generic;
// z1
/*int[] T = new int[115];
T[0] = 3;
for (int i = 1; i < T.Length; i++)
{
    T[i] = T[i - 1] + 4;
}
foreach (var i in T) Console.Write(i + " ");
*/
// z2

/*StreamReader sr = new StreamReader(@"..\..\..\Osoby.txt");

string[] linia = new string[3];
Osoba[] osoby = new Osoba[5];

int i = 0;
while (!sr.EndOfStream)
{
    linia = sr.ReadLine().Split(";");
    Osoba os;
    os.imie = linia[0];
    os.nazwisko = linia[1];
    os.wiek = int.Parse(linia[2]);
    Console.WriteLine($"imie: {os.imie}, nazwisko: {os.nazwisko}, wiek: {os.wiek}");
    osoby[i] = os;
    i++;
}
sr.Close();
foreach (var item in osoby)
{
    Console.WriteLine(item.imie + " " + item.nazwisko + " " + item.wiek);

}*/



/*struct Osoba
{
    public string imie;
    public string nazwisko;
    public int wiek;
}*/





// z3
//źlleeeeeeeeeeeeeeeeeeeee
/*string[] samogloski = { "a", "e", "y", "i", "o", "u"};
string[] main = new string[6];
Random r = new Random();

for (int i = 0; i < 6; i++)
{
    
    string slowo = "";
    string[] uzyte = {"","",""};
    for (int j = 0; j < 3; j++)
    {
        string samogloska = "";
        do{
            samogloska = samogloski[r.Next(0, 6)];
            if(!uzyte.Contains(samogloska))  uzyte[j] = samogloska;
        } while(!uzyte.Contains(samogloska));
        slowo += samogloska;
    }
    main[i] = slowo;

}
foreach (var item in main)
{
    Console.WriteLine(item);
}*/
//źleeeeeeeeeeeeeeeee

//git tu

/*List<char> LS = new List<char> { 'a', 'e', 'i', 'o', 'u', 'y' };
List<string> S = new List<string>();
List<char> LSC = new List<char>();

Random r = new Random();
string słowo;
int numer;
for (int i = 0; i < 6; i++)
{
    LSC = LS.ToList();
    słowo = "";
    for (int j = 0; j < 3; j++)
    {
        numer = r.Next(0, LSC.Count);
        słowo = słowo + LSC[numer];
        LSC.RemoveAt(numer);
    }
    S.Add(słowo);
}
foreach (var item in S)
{
    Console.Write(item + "\n");
}*/

// z4
//4.Stwórz kolejkę(queue) 4 losowych liczb fibonacciego < 100 (mogą się powtarzać). 
//Wyświetl kolejkę, usuń z niej 2 elementy i wyświetl pozostałe 2

/*
int rekufibo(int n)
{
    if (n == 0) return 1;
    if (n == 1) return 1;
    return rekufibo(n - 1) + rekufibo(n-2);
}
ArrayList fibo = new ArrayList();

int i = 1;
while (rekufibo(i) < 100)
{
    fibo.Add(rekufibo(i));
    i++;
}


Random r = new Random();
Queue q = new Queue();

for (int j = 0; j < 4; j++)
{
    q.Enqueue(fibo[r.Next(0, fibo.Count)]);
}

foreach (var item in q)
{
    Console.Write(item + " ");
}
Console.WriteLine();
q.Dequeue();
q.Dequeue();
foreach (var item in q)
{
    Console.Write(item + " ");
}*/

/*5.Stwórz stos(stack) 5 kolejnych dwucyfrowych liczb pierwszych.
Wyświetl stos, usuń 3 wyrazy i zwów wyświetl stos.*/


int[] T = { 11, 13, 17, 19, 23 };
Stack stack = new Stack();
for (int i = 0; i < 5; i++)
{
    stack.Push(T[i]);
}

foreach (var item in stack)
{
    Console.WriteLine(item + " ");
}

stack.Pop();
stack.Pop();




















