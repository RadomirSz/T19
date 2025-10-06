import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        String m = "";
        Scanner s = new Scanner(System.in);
        m = s.nextLine();
        int n = Integer.parseInt(m);

        ArrayList<Integer> lista = new ArrayList<Integer>();
        for (int i = 1; i <= n; i++) {
            if(i%S(i)==0){
                lista.add(i);
            }
        }
        float srednia = 0;
        for (int i = 0; i < lista.size(); i++) {
            System.out.println(lista.get(i));
            srednia += S(lista.get(i) / lista.size());
        }
        System.out.println("liczba tych liczb: " + lista.size());
        System.out.println("srednia sumy cyfr tych liczb: " + srednia);

    }
    public static int S(int n){
        int suma = 0;
        while(n>0){
            suma += n%10;
            n = n/10;
        }
        return suma;
    }
}