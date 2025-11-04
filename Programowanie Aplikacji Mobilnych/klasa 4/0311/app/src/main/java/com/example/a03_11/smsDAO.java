package com.example.a03_11;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

import java.util.ArrayList;
import java.util.List;

public class smsDAO {
    private Context context;
    private DBhelper dbHelper;

    public smsDAO(Context context) {
        this.context = context;
        dbHelper = new DBhelper(context);
    }

    public long dodajSms(Sms sms){
        SQLiteDatabase db = dbHelper.getWritableDatabase();
        ContentValues cv = new ContentValues();
        cv.put("title", sms.getTitle());
        cv.put("message", sms.getMessage());
        long id = db.insert("Smsy",null,cv);
        return id;

    }
    public List<Sms> pobierzSmsy(){
        SQLiteDatabase db = dbHelper.getReadableDatabase();
        String q = "SELECT * FROM Smsy";
        Cursor c = db.rawQuery(q,null);
        String tit, msg;
        int t,m,i, id;
        List<Sms> smsy = new ArrayList<>();
        while (c.moveToNext()){
            i = c.getColumnIndex("_id");
            t = c.getColumnIndex("title");
            m = c.getColumnIndex("message");
            id = c.getInt(i);
            tit = c.getString(t);
            msg = c.getString(m);
            smsy.add(new Sms(id,tit,msg));
        }
        c.close();
        return smsy;
    }

    public Boolean usunSms(int position) {
        SQLiteDatabase db = dbHelper.getWritableDatabase();
        long did = db.delete("Smsy","_id = ?",
                new String[]{
                    String.valueOf(position)
                }
        );
        if (did<0) return false;
        return true;
    }
}











