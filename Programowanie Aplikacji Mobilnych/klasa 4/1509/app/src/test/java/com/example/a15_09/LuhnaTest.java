package com.example.a15_09;

import static org.junit.Assert.assertEquals;

import junit.framework.TestCase;

import org.junit.Test;

public class LuhnaTest{
    @Test
    public void LuhnaTest1(){
        Luhna lh = new Luhna();
        int w = lh.luhna("4791312352105534");
        assertEquals(60,w);
    }
    @Test
    public void LuhnaTest2(){
        Luhna lh = new Luhna();
        int w = lh.luhna("4566945729580997");
        assertEquals(90,w);
    }
}