package com.example.a03_11;

import static android.app.PendingIntent.getActivity;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.Dialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListAdapter;
import android.widget.ListView;
import android.widget.SimpleCursorAdapter;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.ActionBar;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    Button btn;
    ListView lv;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        ActionBar a = getSupportActionBar();
        a.setTitle("heloł");



        lv = findViewById(R.id.lv1);
        smsDAO dao = new smsDAO(getApplicationContext());
        List<Sms> smsy = dao.pobierzSmsy();
        ArrayAdapter<Sms> aa = new ArrayAdapter(this, android.R.layout.simple_selectable_list_item,smsy);
        lv.setAdapter(aa);

        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Sms currSms = smsy.get(position);

                AlertDialog.Builder builder = new AlertDialog.Builder(MainActivity.this);
                builder.setMessage("Are you sure you want to delete this SMS?"); // Add a message for clarity
                builder.setPositiveButton("Rozumiem", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {
                        Boolean result = dao.usunSms(currSms.getId());
                        if (result) {
                            Toast.makeText(MainActivity.this, "Usunięto", Toast.LENGTH_SHORT).show();
                            smsy.remove(position);
                            aa.notifyDataSetChanged();
                        } else {
                            Toast.makeText(MainActivity.this, "Nie usunięto", Toast.LENGTH_SHORT).show();
                        }
                    }
                });
                builder.setNegativeButton("Wycofaj", null); // Setting null to dismiss the dialog

                AlertDialog dialog = builder.create();
                dialog.show();

//                Boolean b = dao.usunSms(currSms.getId());
//                if (b){
//                    Toast.makeText(MainActivity.this, "usunelo", Toast.LENGTH_SHORT).show();
//                    smsy.remove(position);
//                    aa.notifyDataSetChanged();
//                }
//                else {
//                    Toast.makeText(MainActivity.this, "nie usunelo", Toast.LENGTH_SHORT).show();
//                }
            }
        });



        btn = findViewById(R.id.addBtn);
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(MainActivity.this,AddSmsActivity.class);
                startActivity(i);
            }
        });



    }
}