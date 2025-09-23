package kino;


import java.util.ArrayList;

public class Kino {
    public ArrayList<Sala> Sale = new ArrayList<>();

    public Kino() {
        Sale.add(new Sala("Narwal"));
        //Sale.add(new Sala("Biedronka"));
        //Sale.add(new Sala("Koala"));
    }

    // pokazuje ile jest miejsc
    public int countAvailableSeats() {
        int total = 0;
        for (Sala sala : Sale){
            total += sala.obliczIloscWolnych();
        }
        return total;
    }

    // pokazuje wszystkie miejsca
    public void displayAllSeats() {
        for (Sala sala : Sale) {
            sala.wyswietlSale();
            System.out.println();
        }
    }
    public void wyswietlWszystkieMiejca() {
        for (Sala sala : Sale) {
            System.out.println("\n\n");
            System.out.println(sala.getNazwa());
            System.out.println("\n");
            sala.wyswietlSale();
            System.out.println("\n\n");
        }
    }
}
