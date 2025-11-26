package zadanie;

public class TablicaRunnableDesc implements Runnable{
    Tablica t;

    public TablicaRunnableDesc(Tablica t) {
        this.t = t;
    }

    @Override
    public void run() {
        for (int i = t.getT().length-1; i>=0; i--) {
            t.wstaw(i,"✅");
            try {
                Thread.sleep(100);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }
}
