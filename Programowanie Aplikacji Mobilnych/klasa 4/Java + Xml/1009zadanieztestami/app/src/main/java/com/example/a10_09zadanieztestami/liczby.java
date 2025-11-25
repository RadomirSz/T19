package com.example.a10_09zadanieztestami;

public class liczby
{
    public int nwd(int a, int b)
    {
        while(a!=b){
            if (a>b){a-=b;}
            if (b>a){b-=a;}
        }
        return a;
    }
}
