package com.example.myapplication;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.SeekBar;
import android.widget.TextView;

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

        SeekBar sb = findViewById(R.id.sbLiczbaSerii);
        TextView tvwartosc = findViewById(R.id.tvWartoscSuwaka);
        TextView tvwynik = findViewById(R.id.tvWynik);
        Button btn = findViewById(R.id.btnZapisz);
        ImageView iv = findViewById(R.id.ivikona);
        EditText et = findViewById(R.id.etNazwaCw);
        CheckBox cb = findViewById(R.id.cbDoUlubionych);
        RadioGroup rg = findViewById(R.id.rg);

        sb.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int progress, boolean fromUser) {
                tvwartosc.setText("liczba: " + progress);
            }
            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {}
            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {}
        });

        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(et.getText().isEmpty()){
                    tvwynik.setText("Podaj nazwę ćwiczenia");
                    return;
                }
                int progress = sb.getProgress();
                if(progress >= 1 && progress <= 4){
                    iv.setImageResource(R.drawable.minus);
                }
                if(progress >= 5 && progress <= 10){
                    iv.setImageResource(R.drawable.plus);
                }
                int selected = rg.getCheckedRadioButtonId();
                if(selected == -1){
                    tvwynik.setText("Wybierz grupę mięśniową.");
                    return;
                }
                RadioButton selectedRadio = findViewById(selected);
                String grupa = selectedRadio.getText().toString();
                String out = "Ćwiczenie: " + et.getText() +
                        "\nGrupa: " + grupa +
                        "\nSerie: " + sb.getProgress();
                if(cb.isChecked()){
                    tvwynik.setText(out + "❤️");
                }
                else{
                    tvwynik.setText(out);
                }
            }
        });
    }
}