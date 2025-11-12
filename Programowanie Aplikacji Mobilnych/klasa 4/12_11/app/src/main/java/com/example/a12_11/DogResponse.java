package com.example.a12_11;

import com.google.gson.annotations.SerializedName;
public class DogResponse {

    @SerializedName("message")
    private String message;
    @SerializedName("status")
    private String status;
    public String getMessage() {
        return message;
    }
    public String getStatus() {
        return status;
    }
}
