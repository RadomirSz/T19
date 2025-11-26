package watki;

public class Program {
    public static void main(String[] args){
//        Petla p = new Petla();
//        p.setName("hary");
//        p.start(); // lub p.run();

        Thread t1 = new Thread(new IPetla());
        t1.setPriority(2);

        Thread t2 = new Thread(()->{
            System.out.println("iger");
        });

        t2.start();
        t1.start();


    }
}
