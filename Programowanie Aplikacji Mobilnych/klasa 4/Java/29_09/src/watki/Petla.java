package watki;
public class Petla extends Thread
{
    public void run(){
        System.out.println(Thread.currentThread().getName());
    }
}
