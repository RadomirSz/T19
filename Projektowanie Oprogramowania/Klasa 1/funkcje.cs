// funkcje są nam znane z matematyki i informatyki: f(x) WriteLine()
/*
 typ_zwracany nazwa(parametry)
{
instrukcje
}
 */
void przywitaj()
{
    Console.WriteLine("welcome master");
}

przywitaj();
przywitaj();

//napisz funkcja, która obliczy sumę przekazanych przez parametr 3 liczb
/*void suma(int a, int b, int c)
{
    Console.WriteLine(a+b+c);
}
suma(2,4,6);
Console.WriteLine();

int mnożenie(int x, int y) 
{
    return x * y;
}
Console.WriteLine(mnożenie(2,5));
*/
//napisz funkcje dajaca rabat(cena,rabat) na towar

double rabat(double c, int d)
{
    return (c - (c * (d/100d)));
}
Console.WriteLine(rabat(100,25));