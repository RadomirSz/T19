package zadanie;

public class programik {

    public static void main(String[] args){
        Thread t1 = new Thread(new Petla());
        t1.start();

        for (int i = 1; i < 15; i++) {
            System.out.println(" z maina " + i);
        }

    }
}
