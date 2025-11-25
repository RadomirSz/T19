package com.example.a10_09zadanieztestami;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
    private EditText edit1, edit2;
    private Button btn1;
    private liczby liczby;
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

        btn1 = findViewById(R.id.btn);
        edit1 = findViewById(R.id.input1);
        edit2 = findViewById(R.id.input2);



        btn1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int l1 = Integer.parseInt(edit1.getText().toString());
                int l2 = Integer.parseInt(edit2.getText().toString());
                int w = liczby.nwd(l1,l2);
                Toast.makeText(MainActivity.this, w+"", Toast.LENGTH_SHORT).show();
            }
        });
    }
}