import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        String m = "";
        Scanner s = new Scanner(System.in);
        m = s.nextLine();
        int n = Integer.parseInt(m);

        ArrayList<Integer> lista = new ArrayList<Integer>();
        ArrayList<Integer> listb = new ArrayList<Integer>();

        for (int a = 1; a <= n; a++) {
            for (int b = 1; b <= n; b++) {
                if (a<b && (a+b)%(a*b) == 1 ) {
                    lista.add(a);
                    listb.add(b);
                }
            }
        }
        System.out.println(listb.size());
        for (int i = 0; i < lista.size(); i++) {
            System.out.println(lista.get(i) + " " + listb.get(i));
        }


        //srednia
        float srednia = 0;
        for (int i = 0; i < lista.size(); i++) {
            srednia += (listb.get(i) - lista.get(i)) ;
        }
        System.out.println(srednia / lista.size());
    }
}