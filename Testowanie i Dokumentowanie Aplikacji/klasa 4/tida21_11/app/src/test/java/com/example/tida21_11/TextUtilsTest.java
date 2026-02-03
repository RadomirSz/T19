package com.example.tida21_11;

import junit.framework.TestCase;

import org.junit.Test;

public class TextUtilsTest extends TestCase {
    @Test
    public void testKajak() {
        assertTrue(TextUtils.isPalindrome("kajak"));
    }
    @Test
    public void testAnna() {
        assertTrue(TextUtils.isPalindrome("Anna"));
    }
    @Test
    public void testNotPalindrome() {
        assertFalse(TextUtils.isPalindrome("test"));
    }
    @Test
    public void testEmpty() {
        assertTrue(TextUtils.isPalindrome(""));
    }
}
