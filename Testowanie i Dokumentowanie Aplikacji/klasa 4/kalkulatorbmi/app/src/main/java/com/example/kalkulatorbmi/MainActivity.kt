package com.example.kalkulatorbmi

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.text.KeyboardOptions
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.input.KeyboardType
import androidx.compose.ui.text.style.TextAlign
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.kalkulatorbmi.ui.theme.KalkulatorbmiTheme
import kotlin.math.pow

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContent {
            KalkulatorbmiTheme {
                Scaffold(modifier = Modifier.fillMaxSize()) { innerPadding ->
                    BMICalculator(modifier = Modifier.padding(innerPadding))
                }
            }
        }
    }
}

@Composable
fun BMICalculator(modifier: Modifier = Modifier) {
    var weight by remember { mutableStateOf("") }
    var height by remember { mutableStateOf("") }
    var bmi by remember { mutableStateOf<Double?>(null) }
    var bmiCategory by remember { mutableStateOf("") }
    var categoryColor by remember { mutableStateOf(Color.Gray) }

    Column(
        modifier = modifier
            .fillMaxSize()
            .padding(24.dp),
        horizontalAlignment = Alignment.CenterHorizontally,
        verticalArrangement = Arrangement.Center
    ) {
        Text(
            text = "Kalkulator BMI",
            fontSize = 32.sp,
            fontWeight = FontWeight.Bold,
            modifier = Modifier.padding(bottom = 32.dp)
        )

        OutlinedTextField(
            value = weight,
            onValueChange = { weight = it },
            label = { Text("Waga (kg)") },
            keyboardOptions = KeyboardOptions(keyboardType = KeyboardType.Decimal),
            modifier = Modifier
                .fillMaxWidth()
                .padding(bottom = 16.dp),
            singleLine = true
        )

        OutlinedTextField(
            value = height,
            onValueChange = { height = it },
            label = { Text("Wzrost (cm)") },
            keyboardOptions = KeyboardOptions(keyboardType = KeyboardType.Decimal),
            modifier = Modifier
                .fillMaxWidth()
                .padding(bottom = 24.dp),
            singleLine = true
        )

        Button(
            onClick = {
                val weightValue = weight.toDoubleOrNull()
                val heightValue = height.toDoubleOrNull()

                if (weightValue != null && heightValue != null && heightValue > 0) {
                    val heightInMeters = heightValue / 100
                    val calculatedBMI = weightValue / heightInMeters.pow(2)
                    bmi = calculatedBMI

                    when {
                        calculatedBMI < 16.0 -> {
                            bmiCategory = "Wygłodzenie"
                            categoryColor = Color(0xFFD32F2F)
                        }
                        calculatedBMI < 17.0 -> {
                            bmiCategory = "Wychudzenie"
                            categoryColor = Color(0xFFE64A19)
                        }
                        calculatedBMI < 18.5 -> {
                            bmiCategory = "Niedowaga"
                            categoryColor = Color(0xFFFFA726)
                        }
                        calculatedBMI < 25.0 -> {
                            bmiCategory = "Waga prawidłowa"
                            categoryColor = Color(0xFF66BB6A)
                        }
                        calculatedBMI < 30.0 -> {
                            bmiCategory = "Nadwaga"
                            categoryColor = Color(0xFFFFA726)
                        }
                        calculatedBMI < 35.0 -> {
                            bmiCategory = "Otyłość I stopnia"
                            categoryColor = Color(0xFFE64A19)
                        }
                        calculatedBMI < 40.0 -> {
                            bmiCategory = "Otyłość II stopnia"
                            categoryColor = Color(0xFFD32F2F)
                        }
                        else -> {
                            bmiCategory = "Otyłość III stopnia"
                            categoryColor = Color(0xFF9C27B0)
                        }
                    }
                }
            },
            modifier = Modifier
                .fillMaxWidth()
                .height(56.dp),
            colors = ButtonDefaults.buttonColors(
                containerColor = MaterialTheme.colorScheme.primary
            )
        ) {
            Text("Oblicz BMI", fontSize = 18.sp)
        }

        Spacer(modifier = Modifier.height(32.dp))

        bmi?.let {
            Card(
                modifier = Modifier
                    .fillMaxWidth()
                    .padding(vertical = 8.dp),
                colors = CardDefaults.cardColors(
                    containerColor = MaterialTheme.colorScheme.surfaceVariant
                )
            ) {
                Column(
                    modifier = Modifier
                        .padding(24.dp)
                        .fillMaxWidth(),
                    horizontalAlignment = Alignment.CenterHorizontally
                ) {
                    Text(
                        text = "Twoje BMI:",
                        fontSize = 20.sp,
                        fontWeight = FontWeight.Medium
                    )
                    Text(
                        text = String.format("%.2f", it),
                        fontSize = 48.sp,
                        fontWeight = FontWeight.Bold,
                        color = categoryColor,
                        modifier = Modifier.padding(vertical = 8.dp)
                    )
                    Text(
                        text = bmiCategory,
                        fontSize = 24.sp,
                        fontWeight = FontWeight.SemiBold,
                        color = categoryColor,
                        textAlign = TextAlign.Center
                    )
                }
            }

            Spacer(modifier = Modifier.height(16.dp))

            Card(
                modifier = Modifier.fillMaxWidth(),
                colors = CardDefaults.cardColors(
                    containerColor = MaterialTheme.colorScheme.secondaryContainer
                )
            ) {
                Column(
                    modifier = Modifier.padding(16.dp)
                ) {
                    Text(
                        text = "Kategorie BMI:",
                        fontSize = 16.sp,
                        fontWeight = FontWeight.Bold,
                        modifier = Modifier.padding(bottom = 8.dp)
                    )
                    BMICategoryRow("< 16.0", "Wygłodzenie")
                    BMICategoryRow("16.0 - 16.9", "Wychudzenie")
                    BMICategoryRow("17.0 - 18.4", "Niedowaga")
                    BMICategoryRow("18.5 - 24.9", "Waga prawidłowa")
                    BMICategoryRow("25.0 - 29.9", "Nadwaga")
                    BMICategoryRow("30.0 - 34.9", "Otyłość I stopnia")
                    BMICategoryRow("35.0 - 39.9", "Otyłość II stopnia")
                    BMICategoryRow("≥ 40.0", "Otyłość III stopnia")
                }
            }
        }
    }
}

@Composable
fun BMICategoryRow(range: String, category: String) {
    Row(
        modifier = Modifier
            .fillMaxWidth()
            .padding(vertical = 2.dp),
        horizontalArrangement = Arrangement.SpaceBetween
    ) {
        Text(text = range, fontSize = 14.sp)
        Text(text = category, fontSize = 14.sp)
    }
}

@Preview(showBackground = true)
@Composable
fun BMICalculatorPreview() {
    KalkulatorbmiTheme {
        BMICalculator()
    }
}