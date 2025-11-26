package zadanie;

import java.util.Arrays;

public class TablicaRunnableDisplay implements Runnable{
    Tablica t;

    public TablicaRunnableDisplay(Tablica t) {
        this.t = t;
    }

    @Override
    public void run() {
        for (int i = 0; i < 20; i++) {
            String a = Arrays.toString(t.getT()).replaceAll("\\[|\\]|\\,", "");
            System.out.println(a);
            try {
                Thread.sleep(300);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }

    }
}
