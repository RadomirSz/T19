package com.example.z4_generatorhasel

import android.content.SharedPreferences
import android.os.Bundle
import android.widget.Button
import android.widget.CheckBox
import android.widget.ImageView
import android.widget.RadioButton
import android.widget.RadioGroup
import android.widget.SeekBar
import android.widget.Spinner
import android.widget.Switch
import android.widget.TextView
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    private lateinit var sharedPreferences: SharedPreferences
    private val PREFS_NAME = "PasswordGeneratorPrefs"

    private lateinit var seekBar: SeekBar
    private lateinit var tvLength: TextView
    private lateinit var cbLower: CheckBox
    private lateinit var cbUpper: CheckBox
    private lateinit var cbDigits: CheckBox
    private lateinit var cbSpecial: CheckBox
    private lateinit var spinner: Spinner
    private lateinit var radioGroup: RadioGroup
    private lateinit var rbBasic: RadioButton
    private lateinit var rbMixed: RadioButton
    private lateinit var rbAdvanced: RadioButton
    private lateinit var switchSave: Switch
    private lateinit var btnGenerate: Button
    private lateinit var imageStrength: ImageView
    private lateinit var tvPasswords: TextView

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        sharedPreferences = getSharedPreferences(PREFS_NAME, MODE_PRIVATE)

        seekBar = findViewById(R.id.seekBarLength)
        tvLength = findViewById(R.id.tvLength)
        cbLower = findViewById(R.id.cbLower)
        cbUpper = findViewById(R.id.cbUpper)
        cbDigits = findViewById(R.id.cbDigits)
        cbSpecial = findViewById(R.id.cbSpecial)
        spinner = findViewById(R.id.spinnerCount)
        radioGroup = findViewById(R.id.radioGroupMode)
        rbBasic = findViewById(R.id.rbBasic)
        rbMixed = findViewById(R.id.rbMixed)
        rbAdvanced = findViewById(R.id.rbAdvanced)
        switchSave = findViewById(R.id.switchSave)
        btnGenerate = findViewById(R.id.btnGenerate)
        imageStrength = findViewById(R.id.imageStrength)
        tvPasswords = findViewById(R.id.tvPasswords)

        loadSettings()

        seekBar.setOnSeekBarChangeListener(object : SeekBar.OnSeekBarChangeListener {
            override fun onProgressChanged(seekBar: SeekBar?, progress: Int, fromUser: Boolean) {
                tvLength.text = "$progress znaków"
            }

            override fun onStartTrackingTouch(seekBar: SeekBar?) {}
            override fun onStopTrackingTouch(seekBar: SeekBar?) {}
        })

        btnGenerate.setOnClickListener {
            if (!(cbUpper.isChecked || cbLower.isChecked || cbDigits.isChecked || cbSpecial.isChecked)) {
                Toast.makeText(this, "Wybierz przynajmniej jednego checkboxa!", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }

            if (switchSave.isChecked) {
                saveSettings()
            }

            val passwords = generatePasswords(
                seekBar.progress,
                spinner.selectedItem.toString().toInt(),
                getSelectedMode()
            )

            tvPasswords.text = passwords.joinToString("\n")

            val strength = evaluatePasswordStrength(passwords[0])
            updateStrengthImage(strength)
        }
    }

    private fun generatePasswords(
        length: Int,
        count: Int,
        mode: String
    ): List<String> {
        val passwords = mutableListOf<String>()
        val charPool = buildCharPool()

        repeat(count) {
            val password = when (mode) {
                "basic" -> generateBasicPassword(length, charPool)
                "mixed" -> generateMixedOrAdvancedPassword(length, charPool)
                "advanced" -> generateMixedOrAdvancedPassword(length, charPool)
                else -> generateBasicPassword(length, charPool)
            }
            passwords.add(password)
        }

        return passwords
    }
    private fun buildCharPool(): String {
        var pool = ""
        if (cbLower.isChecked) pool += "abcdefghijklmnopqrstuvwxyz"
        if (cbUpper.isChecked) pool += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        if (cbDigits.isChecked) pool += "0123456789"
        if (cbSpecial.isChecked) pool += "!@#$%^&*()"
        return pool
    }
    private fun generateBasicPassword(length: Int, charPool: String): String {
        return (1..length)
            .map { charPool.random() }
            .joinToString("")
    }
    private fun generateMixedOrAdvancedPassword(
        length: Int,
        charPool: String
    ): String {
        val password = mutableListOf<Char>()

        if (cbLower.isChecked) password.add("abcdefghijklmnopqrstuvwxyz".random())
        if (cbUpper.isChecked) password.add("ABCDEFGHIJKLMNOPQRSTUVWXYZ".random())
        if (cbDigits.isChecked) password.add("0123456789".random())
        if (cbSpecial.isChecked) password.add("!@#$%^&*()".random())

        while (password.size < length) {
            password.add(charPool.random())
        }

        return password.shuffled().joinToString("")
    }

    private fun evaluatePasswordStrength(password: String): String {
        val length = password.length
        val hasLower = password.any { it.isLowerCase() }
        val hasUpper = password.any { it.isUpperCase() }
        val hasDigits = password.any { it.isDigit() }
        val hasSpecial = password.any { !it.isLetterOrDigit() }

        var points = length
        if (hasLower) points += 10
        if (hasUpper) points += 15
        if (hasDigits) points += 10
        if (hasSpecial) points += 20

        return when {
            points < 30 -> "słabe"
            points in 30..50 -> "średnie"
            else -> "silne"
        }
    }
    private fun updateStrengthImage(strength: String) {
        imageStrength.contentDescription = strength
    }
    private fun getSelectedMode(): String {
        return when (radioGroup.checkedRadioButtonId) {
            rbBasic.id -> "basic"
            rbMixed.id -> "mixed"
            rbAdvanced.id -> "advanced"
            else -> "basic"
        }
    }
    private fun saveSettings() {
        val editor = sharedPreferences.edit()
        editor.putInt("seekBar", seekBar.progress)
        editor.putBoolean("cbLower", cbLower.isChecked)
        editor.putBoolean("cbUpper", cbUpper.isChecked)
        editor.putBoolean("cbDigits", cbDigits.isChecked)
        editor.putBoolean("cbSpecial", cbSpecial.isChecked)
        editor.putInt("spinner", spinner.selectedItemPosition)
        editor.putInt("radioGroup", radioGroup.checkedRadioButtonId)
        editor.apply()
    }
    private fun loadSettings() {
        val hasSavedSettings = sharedPreferences.contains("seekBar")
        if (hasSavedSettings) {
            switchSave.isChecked = true
            seekBar.progress = sharedPreferences.getInt("seekBar", 6)
            tvLength.text = "${seekBar.progress} znaków"
            cbLower.isChecked = sharedPreferences.getBoolean("cbLower", false)
            cbUpper.isChecked = sharedPreferences.getBoolean("cbUpper", false)
            cbDigits.isChecked = sharedPreferences.getBoolean("cbDigits", false)
            cbSpecial.isChecked = sharedPreferences.getBoolean("cbSpecial", false)
            spinner.setSelection(sharedPreferences.getInt("spinner", 0))

            val savedRadioId = sharedPreferences.getInt("radioGroup", rbBasic.id)
            radioGroup.check(savedRadioId)
        }
    }
}