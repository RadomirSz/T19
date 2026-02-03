package com.example.tida21_11;

import junit.framework.TestCase;

import org.junit.Test;

public class MathToolsTest extends TestCase {

    @Test
    public void testMultiply1() {
        int wynik = MathTools.multiply(3,4);
        assertEquals(12,wynik);
    }
    @Test
    public void testMultiply2() {
        int wynik = MathTools.multiply(0,10);
        assertEquals(0,wynik);
    }
    @Test
    public void testMultiply3() {
        int wynik = MathTools.multiply(-2,5);
        assertEquals(-10,wynik);
    }
}