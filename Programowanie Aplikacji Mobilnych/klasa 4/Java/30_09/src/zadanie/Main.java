package zadanie;

public class Main {
    public static void main(String[] args) throws InterruptedException {
        Tablica T = new Tablica();

        Thread t1 = new Thread(new TablicaRunnableAsc(T));
        Thread t2 = new Thread(new TablicaRunnableDesc(T));
        Thread t3 = new Thread(new TablicaRunnableDisplay(T));

        t3.start();
        t1.start();
        t2.start();
    }
}