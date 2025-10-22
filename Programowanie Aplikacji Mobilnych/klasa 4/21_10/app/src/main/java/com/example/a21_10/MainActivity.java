package com.example.a21_10;

import android.graphics.Color;
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

    Button btnReg,btnHelp;
    EditText imie,nazwisko,email,haslo,haslo2;
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
        btnHelp = findViewById(R.id.btnHelp);
        btnReg = findViewById(R.id.btnRegister);
        imie = findViewById(R.id.imie);
        nazwisko = findViewById(R.id.nazwisko);
        email = findViewById(R.id.email);
        haslo= findViewById(R.id.haslo);
        haslo2= findViewById(R.id.haslo2);

        btnReg.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String imieStr = imie.getText().toString();
                String nazwiskoStr = nazwisko.getText().toString();
                String emailStr = email.getText().toString();
                String hasloStr = haslo.getText().toString();
                String haslo2Str = haslo2.getText().toString();
                if(imieStr.isEmpty() || nazwiskoStr.isEmpty() || emailStr.isEmpty() || hasloStr.isEmpty() || haslo2Str.isEmpty() || !emailStr.contains("@") || hasloStr.equals(haslo2Str)){
                    Toast.makeText(MainActivity.this, "gówno nie dane", Toast.LENGTH_SHORT).show();
                }
                else {
                    String out = imieStr + ", " + nazwiskoStr + ", " + emailStr;
                    Toast.makeText(MainActivity.this, "dane: " + out, Toast.LENGTH_LONG).show();
                }
            }
        });

        btnHelp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                btnHelp.setBackgroundColor(Color.parseColor("#00FF00"));
                
            }
        });
    }
}