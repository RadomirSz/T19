package com.example.a5_11_room;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    Button btn;
    EditText et;
    ListView lv;

    List<Note> notes;
    List<Note> notesDaoList;
    AppDatabase appDatabase;
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
        btn = findViewById(R.id.btn1);
        et = findViewById(R.id.et1);
        lv = findViewById(R.id.lv1);

        appDatabase = AppDatabase.getInstance(this);
        populateLists();

//        Note note1 = new Note("TRZECIA");
//        new Thread(() ->{
//            appDatabase.notesDao().addNote(note1);
//        }).start();

        ArrayAdapter<Note> aa = new ArrayAdapter<>(this,android.R.layout.simple_list_item_1, notes);
        lv.setAdapter(aa);

        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String message = et.getText().toString();
                appDatabase.notesDao().addNote(new Note(message));
                Toast.makeText(MainActivity.this, "dodano notatkę: " + message, Toast.LENGTH_SHORT).show();
                populateLists();
                aa.notifyDataSetChanged();
                et.setText("");
            }
        });

    }
    void populateLists(){
        notesDaoList = appDatabase.notesDao().getNotes();
        notes = new ArrayList<Note>();
        notes.clear();
        for(var n : notesDaoList){
            notes.add(n);
        }

    }
}

//longclick
// dialog