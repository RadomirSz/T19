package com.example.a12_11;

import retrofit2.Call;
import retrofit2.http.GET;

public interface DogApiService {
    @GET("api/breeds/image/random")
    Call<DogResponse> getRandomDogImage();
}



