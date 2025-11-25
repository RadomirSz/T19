package com.example.a15_09;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.Random;
import java.util.concurrent.TimeUnit;

public class MainActivity extends AppCompatActivity {

    private Button btnLos, btnCheck;
    private TextView tv1, tv2;
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

        tv1 = findViewById(R.id.tv1);
        tv2 = findViewById(R.id.tv2);
        btnLos = findViewById(R.id.btnLosuj);
        btnCheck = findViewById(R.id.btnCheck);

        btnLos.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Random r = new Random();
                String str = "";
                for (int i = 0; i < 16; i++) {
                    int x = r.nextInt(10);
                    str += x;
                    tv1.setText(str);
                }
            }
        });

        btnCheck.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                String number = String.valueOf(tv1.getText());

                Luhna lh = new Luhna();

                int wynik = lh.luhna(number);

                StringBuilder sb = new StringBuilder();
                sb.append("wynik: ");
                sb.append(wynik);
                sb.append("\n");
                sb.append("poprawny numer: ");
                sb.append(wynik%10==0 ? "poprawny" : "niepoprawny");
                tv2.setText(sb.toString());
            }
        });
    }
}