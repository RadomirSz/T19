package zadanie;

public class Petla implements Runnable{
    @Override
    public void run() {
        for (int i = 0; i < 15; i++) {
            System.out.println("z watku " + i);
        }
    }
}
