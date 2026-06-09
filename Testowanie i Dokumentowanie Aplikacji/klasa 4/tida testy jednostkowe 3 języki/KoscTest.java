import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

public class KoscTest {

    @Test
    public void Rzut_GdyDostepna_ZwracaWartoscZPrzedzialu1Do6() {
        Kosc kosc = new Kosc();

        kosc.Rzut();

        assertTrue(kosc.LiczbaOczek >= 1 && kosc.LiczbaOczek <= 6);
    }

    @Test
    public void Rzut_GdyNiedostepna_NieZmieniaWartosci() {
        Kosc kosc = new Kosc(3);
        kosc.Blokuj();

        kosc.Rzut();

        assertEquals(3, kosc.LiczbaOczek);
    }
}
