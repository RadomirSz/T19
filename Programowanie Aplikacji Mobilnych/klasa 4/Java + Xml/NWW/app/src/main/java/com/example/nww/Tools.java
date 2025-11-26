package com.example.nww;

public class Tools {
    public int nww(int a, int b){
        int w = a*b;
        while (a!=b){
            if (a>b) a-=b;
            else b-=a;
        }
        return w/a;
    }
}
