package com.example.a03_11;

public class Sms {
    private int id;
    private String title;
    private String message;

    public Sms(String title, String message) {
        this.title = title;
        this.message = message;
    }

    public Sms(int id, String title, String message) {
        this.id = id;
        this.title = title;
        this.message = message;
    }

    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    @Override
    public String toString() {
        return id + ": " + title + " " + message;
    }
}
