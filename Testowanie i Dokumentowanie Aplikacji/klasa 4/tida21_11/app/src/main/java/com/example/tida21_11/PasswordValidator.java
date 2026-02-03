package com.example.tida21_11;

public class PasswordValidator {

    public static boolean isValid(String password) {
        if (password == null) return false;
        if (password.length() < 6) return false;
        boolean hasUpper = false;
        boolean hasDigit = false;
        for (char c : password.toCharArray()) {
            if (Character.isUpperCase(c)) hasUpper = true;
            if (Character.isDigit(c)) hasDigit = true;
            if (hasUpper && hasDigit) return true;
        }
        return false;
    }
}