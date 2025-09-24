package com.example.a24_09;

public class Tools {
    public int nwd(int a, int b){
        while(a!=b){
            if(a>b) a-=b;
            else b-=a;
        }
        return a;
    }

    public int sumaCyfr(int a){
        int suma = 0;
        while(a>0){
            suma += a%10;
            a=a/10;
        }
        return suma;
    }
}
