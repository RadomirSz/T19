using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace zadania3kwietnia
{
    abstract class Pracownik { }

    class Kosmetyczka : Pracownik { }
    class Fryzjerka : Pracownik { }
    class Manikjurzystka : Pracownik { }
    class Lokal
    {
        public string Adres { get; set; }
        public string NumerTelefonu { get; set; }
        public float StawkaCzynszu { get; set; }

    }
    class Wyposazenie
    {
        public string Nazwa { get; set; }
    }

    class SalonUrody
    {
        Lokal lokal;
        List<Pracownik> lista = new List<Pracownik>();
        List<Wyposazenie> wyposazenieLista = new List<Wyposazenie>();

        public void setLokal(Lokal lokal)
        {
            this.lokal = lokal;
        }

        public void DodajPracownika(Pracownik pracownik)
        {
            lista.Add(pracownik);
        }
        public void DodajWyposażenie(Wyposazenie wyposazenie)
        {
            wyposazenieLista.Add(wyposazenie);
        }
    }
    internal class Program
    {
        static void Main(string[] args) 
        {
        Kosmetyczka k1 = new Kosmetyczka();
        Kosmetyczka k2 = new Kosmetyczka();
        Fryzjerka f1 = new Fryzjerka();
        Manikjurzystka m1 = new Manikjurzystka();

            Lokal l = new Lokal();
            l.Adres = "Dymbiec koło TE 19";
            l.NumerTelefonu = "997";
            l.StawkaCzynszu = 123.45F;

            Wyposazenie sz1 = new Wyposazenie();
            sz1.Nazwa = "Head Szampooun";
            Wyposazenie g1 = new Wyposazenie();
            g1.Nazwa = "Grzebień cieńkościenny";

            SalonUrody salon = new SalonUrody();
            salon.setLokal(l);
            salon.DodajPracownika(k1);
            salon.DodajPracownika(k2);
            salon.DodajPracownika(f1);
            salon.DodajPracownika(m1);
            salon.DodajWyposażenie(sz1);
            salon.DodajWyposażenie(g1);
        }
    }
}


/*#region nowaka
Stwórz fasadę salonu urody, który będzie się składał z:

-lokalu(obiekt z adresem, numerem telefonu oraz stawką czynszu)
- osób zatrudnionych(W FASADZIE! - Lista obiektów typu Kosmetyczka, Fryzjerka oraz Manikjurzystka
  (łącznie 4 osoby ze wszystkich stanowisk)
- wyposażenie salonu(W FASADZIE! - Lista sprzętów i lista materiałów eksploatycyjnch np szampony, grzebienie itp)

abstract class Pracownik { }
class Kosmetyczka : Pracownik { }

List<Pracownik> lista = new();
lista.add(new Kosmetyczka());



4 poziomy dostępu(dziedziczenie i obiekt):
public -> dostęp z klasy jak i z obiektu
protected -> dostęp z klasy, ala nie ma z obiektu
private -> nie ma dostępu z klasy i nie ma z obiektu
internal -> nie ma dostepu z klasy ale jest z obiektu


    abstract class Pracownik { }
class Kosmetyczka : Pracownik { }
class Fryzjerka : Pracownik { }
class Manikiurzystka : Pracownik { }

class Lokal
{
    public string Adres { get; set; }
    public string NumerTelefonu { get; set; }
    public double StawkaCzynszu { get; set; }

}

class Wyposażenie
{
    public string Nazwa { get; set; }
}

class SalonUrody
{
    Lokal lokal;
    List<Pracownik> listaPracowników = new List<Pracownik>();
    List<Wyposażenie> wyposażenie = new List<Wyposażenie>();

}

#endregion*/