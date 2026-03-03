package com.example.kalkulatorrabatu

import android.os.Bundle
import android.widget.Button
import android.widget.CheckBox
import android.widget.EditText
import android.widget.ImageView
import android.widget.RadioButton
import android.widget.RadioGroup
import android.widget.SeekBar
import android.widget.Switch
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)

        val et = findViewById<EditText>(R.id.et1)
        val rabatTv = findViewById<TextView>(R.id.tv1)
        val wynikTv = findViewById<TextView>(R.id.tv2)
        val seekBar = findViewById<SeekBar>(R.id.sb1)
        val radioGroup = findViewById<RadioGroup>(R.id.rg1)
        val radioButtonStandard = findViewById<RadioButton>(R.id.rb1)
        val radioButtonPremium = findViewById<RadioButton>(R.id.rb2)
        val radioButtonVip = findViewById<RadioButton>(R.id.rb3)
        val checkBox = findViewById<CheckBox>(R.id.cb1)
        val switch = findViewById<Switch>(R.id.sw1)
        val button = findViewById<Button>(R.id.btn1)
        val imageView = findViewById<ImageView>(R.id.iv1)


        button.setOnClickListener {
            val cena = et.text.toString()
            if ( cena.isBlank() || cena.toInt() !in 10..10000){

            }
        }
    }
}