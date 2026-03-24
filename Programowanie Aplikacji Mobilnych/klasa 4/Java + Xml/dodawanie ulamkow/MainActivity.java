package com.example.dodawanieuamkw;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    EditText etl1,etm1,etl2,etm2;
    Button btn;
    TextView tv;
    ImageView iv;
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
        btn = findViewById(R.id.btn);
        etl1 = findViewById(R.id.licznik1);
        etm1 = findViewById(R.id.mianownik1);
        etl2 = findViewById(R.id.licznik2);
        etm2 = findViewById(R.id.mianownik2);
        tv = findViewById(R.id.tv1);
        iv = findViewById(R.id.iv);

        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String sA = etl1.getText().toString().trim();
                String sC = etm1.getText().toString().trim();
                String sB = etl2.getText().toString().trim();
                String sD = etm2.getText().toString().trim();

                if (sA.isEmpty() || sB.isEmpty() || sC.isEmpty() || sD.isEmpty()) {
                    tv.setText("Wypełnij wszystkie pola!");
                    return;
                }

                int a, b, c, d;

                try {
                    a = Integer.parseInt(sA);
                    b = Integer.parseInt(sB);
                    c = Integer.parseInt(sC);
                    d = Integer.parseInt(sD);
                } catch (NumberFormatException e) {
                    tv.setText("Wpisz poprawne liczby!");
                    return;
                }

                if (c == 0 || d == 0) {
                    tv.setText("Mianownik nie może być 0!");
                    return;
                }

                int nww1 = nww(c,d);

                int licznik1 = a * nww1/c;
                int licznik2 = b * nww1/d;
                int sumalicznikow = licznik1 + licznik2;

                int nwd1 = nwd(sumalicznikow,nww1);

                int licznikPoSkroceniu = sumalicznikow/nwd1;
                int mianownikPoSkroceniu = nww1/nwd1;

                String out = a+"/"+c+"+"+b+"/"+d + "=";
                if(mianownikPoSkroceniu == 1){
                    out += licznikPoSkroceniu;
                }
                else {
                    out += licznikPoSkroceniu + "/" + mianownikPoSkroceniu;
                }
                tv.setText(out);

                if (licznikPoSkroceniu/mianownikPoSkroceniu >= 1){
                    iv.setImageResource(R.drawable.plus);
                }
                else {
                    iv.setImageResource(R.drawable.minus);
                }
            }
        });
    }
    public static int nwd(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public static int nww(int a, int b) {
        if (a == 0 || b == 0) return 0;
        return Math.abs(a * b) / nwd(a, b);
    }
}