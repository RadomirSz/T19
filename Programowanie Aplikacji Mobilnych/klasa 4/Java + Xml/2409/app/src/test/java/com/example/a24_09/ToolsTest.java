package com.example.a24_09;

import static org.junit.Assert.assertEquals;

import junit.framework.TestCase;

import org.junit.Test;

public class ToolsTest {

    Tools t;
    public void setUp() throws Exception{
        this.t = new Tools();
    }
    @Test
    public void testNwd() {
        int wynik = t.nwd(12,20);
        assertEquals(4,wynik);
    }

    @Test
    public void testSumaCyfr() {
        int wynik = t.sumaCyfr(12313);
        assertEquals(10,wynik);
    }
}