package bankoweZadanie;

public class glowny {
    public static void main(String[] args) throws InterruptedException {
        Konto k = new Konto();

        Thread w1 = new Thread(new KontoRunnable(k));
        Thread w2 = new Thread(new KontoRunnable(k));

        w1.start();
        w2.start();
        w1.join();
        w2.join();

        System.out.println(k.getSaldo());
    }

}
