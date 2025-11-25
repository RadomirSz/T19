package com.example.a15_09;

public class Luhna {

    public int luhna(String numer) {
        int suma = 0;
        int e = 0;
        boolean flaga = true;

        for (int i = 0; i < 16; i++) {
            e = numer.charAt(i) - '0';
            if (flaga) {
                e = e * 2;
            }
            suma += e % 10 + e / 10;
            flaga = !flaga;
        }
        return suma;
    }
}