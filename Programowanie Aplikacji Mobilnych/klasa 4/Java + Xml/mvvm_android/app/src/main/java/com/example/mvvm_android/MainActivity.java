package com.example.mvvm_android;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;
import androidx.lifecycle.ViewModelProvider;

public class MainActivity extends AppCompatActivity {

    TextView tv1,tv2,res;
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
        Button btn = findViewById(R.id.btn1);
        tv1 = findViewById(R.id.tv1);
        tv2 = findViewById(R.id.tv2);
        res = findViewById(R.id.res);

        CalcViewModel model = new ViewModelProvider(this).get(CalcViewModel.class);
        model.getResult().observe(this,res1 ->{
            res.setText(res1);
        });

        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                model.add(tv1.getText().toString(),tv2.getText().toString());
            }
        });
    }
}