package com.example.a29_10;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

import androidx.annotation.Nullable;

public class MyHelper extends SQLiteOpenHelper {
    private final String TABLE_CREATE = "CREATE TABLE Statusy " +
            "(Id INTEGER PRIMARY KEY AUTOINCREMENT, status VARCHAR(255));";
    private final String INSERT_TEST_ROW = "INSERT INTO Statusy(\"status\") VALUES(\"active\");";
     public MyHelper(@Nullable Context context) {
        super(context, "STATUS", null, 1);
         Log.d("BAZABAZA", "Tworzenie bazy...");
    }

    @Override
    public void onCreate(SQLiteDatabase sqLiteDatabase) {
        Log.d("BAZABAZA", "Metoda onCreate");
        sqLiteDatabase.execSQL(TABLE_CREATE);
        sqLiteDatabase.execSQL(INSERT_TEST_ROW);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }
}
