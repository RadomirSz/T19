package watki;

public class IPetla implements Runnable{
    public void run() {
        System.out.println(Thread.currentThread().getPriority());
    }
}
