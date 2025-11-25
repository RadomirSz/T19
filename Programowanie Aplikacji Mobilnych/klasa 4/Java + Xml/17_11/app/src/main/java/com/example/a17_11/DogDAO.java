package com.example.a17_11;

import androidx.room.Dao;
import androidx.room.Delete;
import androidx.room.Insert;
import androidx.room.Query;

import java.util.List;

@Dao
public interface DogDAO {
    @Query("SELECT * FROM dogs;")
    List<DogResponse> getAllDogs();

    @Insert
    void insertDog(DogResponse dogResponse);

    @Delete
    void deleteDog(DogResponse dogResponse);
}