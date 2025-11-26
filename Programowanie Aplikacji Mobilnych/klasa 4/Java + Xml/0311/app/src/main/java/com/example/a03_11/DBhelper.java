package com.example.a03_11;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class DBhelper  extends SQLiteOpenHelper {

    public DBhelper(@Nullable Context context){
        super(context,"Sms.db",null,1);
    }
    @Override
    public void onCreate(SQLiteDatabase db) {
        String q =
"CREATE TABLE Smsy (_id INTEGER PRIMARY KEY AUTOINCREMENT, title VARCHAR(50), message TEXT);";
        db.execSQL(q);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }
}
