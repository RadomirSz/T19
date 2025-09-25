package com.example.a24_09;

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

public class NwdActivity extends AppCompatActivity {

    Button btn;
    EditText input1, input2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_nwd);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        btn = findViewById(R.id.obliczNwd)
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Tools t = new Tools();
                input1 = findViewById(R.id.liczba1);
                input2 = findViewById(R.id.liczba2);
                int liczba1 = Integer.parseInt(input1.getText().toString());
                int liczba2 = Integer.parseInt(input2.getText().toString());
                int wynik = t.nwd(liczba1,liczba2);

                Toast.makeText(NwdActivity.this, "nwd = " + wynik, Toast.LENGTH_SHORT).show();
            }
        });

    }
}