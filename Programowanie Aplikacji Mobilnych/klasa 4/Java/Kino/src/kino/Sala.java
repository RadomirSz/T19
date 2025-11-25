package kino;

public class Sala {
    private int[][] Miejsca = new int [5][5];

    public String getNazwa() {
        return Nazwa;
    }

    private String Nazwa;
    public Sala(String nazwa) {
        Nazwa = nazwa;
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Miejsca[i][j] = 0;
            }
        }
    }
    // sprawdz czy wolne
    public boolean czyWolne(int i, int j) {
        return (Miejsca[i][j] == 0);
    }

    // rezerwuj
    public void rezerwuj(int i, int j) {
        Miejsca[i][j] = 1;
    }

    // anuluj rez
    public void anulujRezerwacje(int i, int j) {
        Miejsca[i][j] = 0;
    }

    // oblicz ile wolnych
    public int obliczIloscWolnych() {
        int suma = 0;
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                if (Miejsca[i][j] == 1) suma++;
            }
        }
        return suma;
    }

    // wyświetl sale
    public void wyswietlSale() {
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                if (Miejsca[i][j] == 1) System.out.print("X");
                else System.out.print("O");
            }
            System.out.println();
        }
    }


}

