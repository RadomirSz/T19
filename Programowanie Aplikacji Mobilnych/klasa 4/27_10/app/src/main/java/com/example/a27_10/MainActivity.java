package com.example.a27_10;

import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.Arrays;
import java.util.List;
import java.util.Random;

public class MainActivity extends AppCompatActivity {

    Button rzut, reset;
    ImageView iv1,iv2,iv3,iv4,iv5;
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

        rzut = findViewById(R.id.rzuc);
        reset = findViewById(R.id.resetuj);
        iv1 = findViewById(R.id.kosc1);
        iv2 = findViewById(R.id.kosc2);
        iv3 = findViewById(R.id.kosc3);
        iv4 = findViewById(R.id.kosc4);
        iv5 = findViewById(R.id.kosc5);
        List<ImageView> ivList = Arrays.asList(iv1,iv2,iv3,iv4,iv5);
        int[] obrazki = {R.drawable.k1,R.drawable.k2,R.drawable.k3,R.drawable.k4,R.drawable.k5,R.drawable.k6,R.drawable.question};
        rzut.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Random r = new Random();
                int[] T = new int[5];
                for (int i = 0; i < T.length; i++) {
                    T[i] = r.nextInt(6);
                    ivList.get(i).setImageResource(obrazki[T[i]]);
                }
            }
        });
        reset.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                for (int i = 0; i < 5; i++) {
                    ivList.get(i).setImageResource(obrazki[6]);
                }
            }
        });
    }
}