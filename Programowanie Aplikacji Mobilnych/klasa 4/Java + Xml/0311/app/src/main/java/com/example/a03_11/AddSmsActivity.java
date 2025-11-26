package com.example.a03_11;

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

public class AddSmsActivity extends AppCompatActivity {

    Button btn;
    EditText e1,e2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_add_sms);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        btn = findViewById(R.id.submitbtn);
        e1 = findViewById(R.id.et1);
        e2 = findViewById(R.id.et2);

        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                smsDAO dao = new smsDAO(getApplicationContext());
                String tit = e1.getText().toString();
                String msg = e2.getText().toString();

                Sms sms = new Sms(tit,msg);
                long id = dao.dodajSms(sms);

                if(id < 0){
                    Toast.makeText(AddSmsActivity.this, "Nie dodano", Toast.LENGTH_SHORT).show();
                }
                else {
                    Toast.makeText(AddSmsActivity.this, "Dodano z id: " + id, Toast.LENGTH_SHORT).show();
                }
            }
        });



    }
}