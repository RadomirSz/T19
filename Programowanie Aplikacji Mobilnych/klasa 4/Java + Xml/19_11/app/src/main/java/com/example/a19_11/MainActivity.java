package com.example.a19_11;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AlertDialog;
import android.content.DialogInterface;
import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    RadioButton rad1,rad2,rad3;
    CheckBox sugar, cream;
    RadioGroup radioGroup;
    Button btn1;
    TextView outTxtV;

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

        rad1 = findViewById(R.id.radbtn1);
        rad2 = findViewById(R.id.radbtn2);
        rad3 = findViewById(R.id.radbtn3);
        radioGroup = findViewById(R.id.radioGroup1);
        sugar = findViewById(R.id.checksugar);
        cream = findViewById(R.id.checkcream);
        btn1 = findViewById(R.id.paybtn);
        outTxtV = findViewById(R.id.output);

        sugar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (sugar.isChecked()) {
                    new AlertDialog.Builder(MainActivity.this)
                        .setTitle("Add Sugar")
                        .setMessage("Are you sure you want to add sugar?")
                        .setPositiveButton("Yes", null)
                        .setNegativeButton(android.R.string.no, (dialog, which) -> {
                            sugar.setChecked(false);
                        }).show();
                }
            }
        });

        cream.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (cream.isChecked()) {
                    new AlertDialog.Builder(MainActivity.this)
                            .setTitle("Add Cream")
                            .setMessage("Are you sure you want to add Cream?")
                            .setPositiveButton("Yes", null)
                            .setNegativeButton("No", (dialog, which) -> {
                                cream.setChecked(false);
                            }).show();
                }
            }
        });

        btn1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String outStr = "";
                int selectedId = radioGroup.getCheckedRadioButtonId();

                if (selectedId != -1) {
                    RadioButton selectedRadioButton = findViewById(selectedId);
                    String selectedCoffee = selectedRadioButton.getText().toString();
                     outStr = selectedCoffee + " ";
                } else {
                    Toast.makeText(MainActivity.this, "Select coffee type", Toast.LENGTH_SHORT).show();
                    return;
                }
                if (cream.isChecked()) {
                    outStr += "Cream ";
                }
                if (sugar.isChecked()) {
                    outStr += "Sugar ";
                }
                outTxtV.setText(outStr);
                outTxtV.setPadding(25, 25, 25, 25);
            }
        });
    }
}