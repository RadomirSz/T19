package com.example.a5_11_room;

import android.content.Context;

import androidx.room.Database;
import androidx.room.Room;
import androidx.room.RoomDatabase;

@Database(entities = {Note.class},version = 1)
public abstract class AppDatabase extends RoomDatabase {
    public abstract notesDao notesDao();

    private static AppDatabase Instance;
    public static AppDatabase getInstance(Context context){
        if(Instance == null)
            Instance = Room.databaseBuilder(context,AppDatabase.class,"notes.db").allowMainThreadQueries().build();
        return Instance;
    };
}
