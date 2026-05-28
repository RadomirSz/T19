namespace tida_inf04czerwiec25.UnitTests;

[TestClass]
public sealed class SzyfrCezaraTests
{
    [TestMethod]
    public void Szyfruje_PodstawoweDane_GdyKluczDodatni()
    {
        var szyfr = new SzyfrCezara("abc", 3);

        var wynik = szyfr.Szyfruj();

        Assert.AreEqual("def", wynik);
    }

    [TestMethod]
    public void Szyfruje_Zawijanie_GdyTekstNaKoncuAlfabetu()
    {
        var szyfr = new SzyfrCezara("xyz", 3);

        var wynik = szyfr.Szyfruj();

        Assert.AreEqual("abc", wynik);
    }

    [TestMethod]
    public void Szyfruje_Odszyfrowanie_GdyKluczUjemny()
    {
        var szyfr = new SzyfrCezara("def", -3);

        var wynik = szyfr.Szyfruj();

        Assert.AreEqual("abc", wynik);
    }

    [TestMethod]
    public void Szyfruje_KluczWiekszyNizAlfabet()
    {
        var szyfr = new SzyfrCezara("abc", 29);

        var wynik = szyfr.Szyfruj();

        Assert.AreEqual("def", wynik);
    }

    [TestMethod]
    public void Szyfruje_ZeSpacja_WTeksicie()
    {
        var szyfr = new SzyfrCezara("abc cd", 2);

        var wynik = szyfr.Szyfruj();

        Assert.AreEqual("cde ef", wynik);
    }
}