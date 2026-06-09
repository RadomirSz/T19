namespace konsolowa.Tests;
class KoscTest
{
    [Test]
    public void Rzut_GdyDostepna_ZwracaWartoscZPrzedzialu1Do6()
    {
        var kosc = new Kosc();

        kosc.Rzut();

        Assert.That(kosc.LiczbaOczek, Is.InRange(1, 6));
    }

    [Test]
    public void Rzut_GdyNiedostepna_NieZmieniaWartosci()
    {
        var kosc = new Kosc(3);
        kosc.Blokuj();

        kosc.Rzut();

        Assert.That(kosc.LiczbaOczek, Is.EqualTo(3));
    }
}