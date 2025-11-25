import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int liczniktak = 0;
        int liczniknie = 0;

        String m = "";
        Scanner s = new Scanner(System.in);
        m = s.nextLine();
        int n = Integer.parseInt(m);

        for (int i = 2; i <= n; i++) {
            if(czyPierwsza(i)){
                if(czyPierwsza(sumaCyfr(i))){
                    liczniktak++;
                }
                else{
                    liczniknie++;
                }
            }
            else{
                liczniknie++;
            }
        }
        System.out.println("tak: " + liczniktak);
        System.out.println("nie: " + liczniknie);
    }

    public static boolean czyPierwsza(int n)
    {
        for(int i = 2; i < n/2;i++) if(n%i==0) return false;
        return true;
    }
    public static int sumaCyfr(int n){
        int suma = 0;
        while(n>0){
            suma += n%10;
            n = n/10;
        }
        return suma;
    }
}