import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class KoszykTest {

    @Test
    void total() {
        Koszyk k = new Koszyk();
        DigitalProduct p1 = new DigitalProduct();
        p1.Price = 10;
        PhysicalProduct p2 = new PhysicalProduct();
        p2.Price = 5;
        k.listaProduktow.add(p1);
        k.listaProduktow.add(p2);
        int wynik = k.total(new PercentageDiscount());
        int powinnoByc = (int) (15*0.8);
        assertEquals(powinnoByc,wynik);
    }
}