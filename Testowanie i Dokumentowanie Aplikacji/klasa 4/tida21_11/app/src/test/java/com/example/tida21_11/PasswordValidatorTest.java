package com.example.tida21_11;

import junit.framework.TestCase;

import org.junit.Test;

public class PasswordValidatorTest extends TestCase {

    @Test
    public void testValid() {
        assertTrue(PasswordValidator.isValid("abc123"));
    }
    @Test
    public void testShort() {
        assertFalse(PasswordValidator.isValid("short"));
    }
    @Test
    public void testNoUpper() {
        assertFalse(PasswordValidator.isValid("abcdef"));
    }
    @Test
    public void testDigitsOnlyButLong() {
        assertTrue(PasswordValidator.isValid("123456"));
    }
}
