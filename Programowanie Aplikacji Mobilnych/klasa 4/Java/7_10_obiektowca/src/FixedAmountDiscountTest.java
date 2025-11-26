import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class FixedAmountDiscountTest {

    @Test
    void discount() {
        int cena = 5;
        FixedAmountDiscount d = new FixedAmountDiscount();
        int wynik = d.discount(cena);
        assertEquals(3,wynik);
    }
}