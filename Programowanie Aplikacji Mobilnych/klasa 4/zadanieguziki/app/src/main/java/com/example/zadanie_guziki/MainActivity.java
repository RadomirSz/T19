package com.example.zadanie_guziki;

import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

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



        Button guzik1 = findViewById(R.id.btn1);
        guzik1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
               View layout = findViewById(R.id.main);
               layout.setBackgroundColor(Color.BLUE);
            }
        });

        Button guzik2 = findViewById(R.id.btn2);
        guzik2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                guzik2.setText("klik");
            }
        });
        Button guzik3 = findViewById(R.id.btn3);
        guzik3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
                // System.exit(0);
            }
        });
    }

}