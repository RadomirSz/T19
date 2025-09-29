package bankoweZadanie;

public class glowny {
    public static void main(String[] args) throws InterruptedException {
        Konto k = new Konto();
        work(k);
        Thread.sleep(1000);
        System.out.println(k.getSaldo());
    }

    public static void work(Konto k){

        Thread w1 = new Thread(new KontoRunnable(k));
        Thread w2 = new Thread(new KontoRunnable(k));

        w1.start();
        w2.start();
    }
}
