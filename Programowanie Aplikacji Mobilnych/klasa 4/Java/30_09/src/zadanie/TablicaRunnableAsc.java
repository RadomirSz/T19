package zadanie;

public class TablicaRunnableAsc implements Runnable{
    Tablica t;

    public TablicaRunnableAsc(Tablica t) {
        this.t = t;
    }

    @Override
    public void run() {
        for (int i = 0; i < t.getT().length; i++) {
            t.wstaw(i,"❌");
            try {
                Thread.sleep(100);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }
}
