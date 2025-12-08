package com.example.a8_12;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.SeekBar;
import android.widget.TextView;
import android.widget.ToggleButton;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    TextView tvGlosnosc;
    SeekBar seekBar;
    ToggleButton tgbtn;
    ListView lvHistoria;
    Button btnZas;
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
        tvGlosnosc = findViewById(R.id.tvGlosnosc);
        seekBar = findViewById(R.id.seekBar);
        tgbtn = findViewById(R.id.tgButton);
        lvHistoria = findViewById(R.id.LvHistoria);

        seekBar.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int i, boolean b) {
                tvGlosnosc.setText("Głośność: " + i + "%");
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {

            }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {

            }
        });
        tgbtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(tgbtn.isChecked())
                    tgbtn.setBackgroundColor(getResources().getColor(R.color.toggleoff));
                else
                    tgbtn.setBackgroundColor(getResources().getColor(R.color.toggleon));
            }
        });


        ArrayList<String> historyList = new ArrayList<>();
        ArrayAdapter<String> historyAdapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, historyList);
        lvHistoria.setAdapter(historyAdapter);


        btnZas = findViewById(R.id.btnZas);
        btnZas.setOnClickListener(v -> {
            String entry = "Głośność: " + seekBar.getProgress() + "%";
            historyList.add(entry);
            historyAdapter.notifyDataSetChanged();
        });
    }
}