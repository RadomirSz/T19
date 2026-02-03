package com.example.tida21_11;

public class TextUtils {

    public static boolean isPalindrome(String s) {
        if (s == null) return false;
        String cleaned = s.toLowerCase();
        int i = 0, j = cleaned.length() - 1;
        while (i < j) {
            if (cleaned.charAt(i) != cleaned.charAt(j)) return false;
            i++; j--;
        }
        return true;
    }
}

