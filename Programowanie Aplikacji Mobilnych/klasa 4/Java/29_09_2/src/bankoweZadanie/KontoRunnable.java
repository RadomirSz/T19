package bankoweZadanie;

public class KontoRunnable implements Runnable {
    Konto k;

    public KontoRunnable(Konto k) {
        this.k = k;
    }

    @Override
    public void run() {
        for (int i = 0; i < 1000; i++) {
            k.dodaj();
        }
    }
}
