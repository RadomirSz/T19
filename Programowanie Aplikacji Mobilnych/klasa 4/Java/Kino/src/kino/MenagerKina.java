package kino;

import java.util.Scanner;

public class MenagerKina {
    public static void main(String[] args){
        Kino k = new Kino();

        boolean exit = false;
        while (!exit){
            Scanner sc = new Scanner(System.in);
            System.out.println("wybierz opcję:\n"+
                    "w - wyswietl raz\n" +
                    "s - wybor sali\n" +
                    "d - dodaj rez\n" +
                    "u - usun\n"+
                    "q - wyjdz");
            String option = sc.nextLine();
            switch (option){
                case "w" -> k.wyswietlWszystkieMiejca();
                case "q" -> exit = true;
                case "d" ->{
                    Scanner m = new Scanner(System.in);
                    String we = m.nextLine();
                    char[] c = we.toCharArray();
                    int a = c[0] - '0';
                    int b = c[2] - '0';
                    if(k.Sale.get(0).czyWolne(a,b)){
                        k.Sale.get(0).rezerwuj(a,b);
                    }
                    else{
                        System.out.println("Miejsce zajete");
                    }
                }
                case "u" ->{
                    Scanner us = new Scanner(System.in);
                    String we = us.nextLine();
                    char[] c = we.toCharArray();
                    int a1 = c[0] - '0';
                    int b1 = c[2] - '0';
                    if(!k.Sale.get(0).czyWolne(a1,b1)){
                        k.Sale.get(0).anulujRezerwacje(a1,b1);
                    }
                    else{
                        System.out.println("Miejsce puste");
                    }
                }

            }


        }


    }
}
