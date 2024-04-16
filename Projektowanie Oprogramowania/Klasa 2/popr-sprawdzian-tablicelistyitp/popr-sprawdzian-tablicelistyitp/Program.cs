////zad 0
/*Console.WriteLine("daj 11 cyfr");
string[] input  = Console.ReadLine().Split(" ");
int[] Tab = new int[11];

for (int i = 0; i < 11; i++)
{
    Tab[i] = int.Parse(input[i]);
}

int małe = 0;
int duże = 0;
int średnie = 0;

for (int i = 0; i < 11; i++)
{
    if (Tab[i] > Tab.Average()) duże++;
    else if (Tab[i] < Tab.Average()) małe++;
    else if (Tab[i] == Tab.Average()) średnie++;
}

if (duże > małe) Console.WriteLine("wielkomiejska");
else if (małe > duże) Console.WriteLine("małorolna");
else Console.WriteLine("małomiasteczkowa");
//tak, istnieje małomiasteczkowa na przykład:
int[] małomiasteczkowa = new int[11] {1,1,1,1,1,2,3,3,3,3,3};
*/

////zad 1

/*int[] T = new int[30];
Random r = new Random();
for (int i = 0; i < 30; i++)
{
    T[i] = r.Next(100,1000);
}
int suma = 0;
int pierwsza = 0;
int ostatnia = 0;
int dlugosc = 1;
int tempdlugosc = 0;

for (int i = 0; i < 29; i++)
{
    if (T[i] < T[i + 1])
    { 
        tempdlugosc++;
    }
    else if (tempdlugosc > dlugosc)
    {
        suma = 0;
        dlugosc = tempdlugosc;
        tempdlugosc = 1;
        for (int j = 0; j < dlugosc; j++)
        {
            suma += T[i - j];
            pierwsza = T[i - j];
        }
        ostatnia = T[i];
    }
    else 
    {
        tempdlugosc = 1;
    }
}

foreach (var item in T)
{
    Console.Write(item + " ");
}
Console.WriteLine();
Console.WriteLine($"pierwsza: {pierwsza}, ostatnia: {ostatnia}, suma: {suma}, dlugosc: {dlugosc}");
Console.WriteLine();*/


//zad 2
Random r = new Random();
List<int> L1 = new List<int>();
List<int> L2 = new List<int>();
List<int> wynik = new List<int>();
Dictionary<int,int> pomocniczy = new Dictionary<int,int>();

int[] pom = new int[3];
while (L1.Count < 6)
{
    int x = r.Next(0,10);
    if(!L1.Contains(x)) L1.Add(x);
}

for (int i = 0; i < 3; i++)
{
    pom[i] = r.Next(0,10);
}
while (L2.Count < 6)
{
    L2.Add(pom[r.Next(0,3)]);
}

for (int i = 0; i < 10; i++) pomocniczy.Add(i, 0);

foreach (var item in L1) pomocniczy[item]++;
foreach (var item in L2) pomocniczy[item]++;

foreach (var item in pomocniczy)
{
    //Console.WriteLine("key:" + item.Key + " value: " + item.Value);
    if (!(item.Value == 1)) wynik.Add(item.Key);
    if (item.Value > 2) wynik.Add(item.Key);
}

Console.WriteLine("L1:");
foreach (int x in L1) Console.Write(x + " ");
Console.WriteLine();
Console.WriteLine("L2:");
foreach (int x in L2) Console.Write(x + " ");
Console.WriteLine();
Console.WriteLine("wynik:");
foreach (var item in wynik) Console.Write(item + " ");



////zad 3
/*using System.Collections;
string[] litery = new string[4] { "A", "B", "C", "D" };

Random rand = new Random();

ArrayList strings = new ArrayList();
for (int i = 0; i < 30; i++)
{
    string a = litery[rand.Next(0, 4)];
    string b = litery[rand.Next(0, 4)];
    string c = litery[rand.Next(0, 4)];
    strings.Add(a + b + c);
}
List<string> anagramy = new List<string>();
int pary = 0;

foreach (var item1 in strings)
{
    foreach (var item2 in strings)
    {
        string s1 = item1.ToString();
        string s2 = item2.ToString();
        if (s1 != s2)
        {
            if (isAnagram(s1, s2) && !anagramy.Contains(s1 + "-" + s2))
            {
                anagramy.Add(s1 + "-" + s2);
                pary++;
            }
        }
    }
}

foreach (var item in anagramy)
{
    Console.WriteLine(item);
}

foreach (var item in strings)
{
    Console.WriteLine(item);
}
Console.WriteLine(pary);

bool isAnagram(string a, string b)
{
    char[] s1C = a.ToCharArray();
    char[] s2C = b.ToCharArray();
    Array.Sort(s1C);
    Array.Sort(s2C);

    for (int i = 0; i < a.Length; i++)
    {
        if (s1C[i] != s2C[i]) return false;
    }

    return true;
}
*/

Console.ReadKey();