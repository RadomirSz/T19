package com.example.a17_11;

import android.content.Context;

import androidx.room.Database;
import androidx.room.Room;
import androidx.room.RoomDatabase;

@Database(entities = {DogResponse.class}, version = 1)
public abstract class AppDatabase extends RoomDatabase {
    public abstract DogDAO dogDao();
    private static AppDatabase Instance;

    public static AppDatabase getInstance(Context context) {
        if (Instance == null)
            Instance = Room.databaseBuilder(context,AppDatabase.class,"Dogs.db").allowMainThreadQueries().build();
        return Instance;
    }
}