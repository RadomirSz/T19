package zadanie;

import java.util.Arrays;

public class Tablica {
    private String[] T;

    public Tablica() {
        T = new String[50];
        Arrays.fill(T,"😊");
    }

    public String[] getT() {
        return T;
    }

    public void wstaw(int position, String str){
        T[position] = str;
    }
}
