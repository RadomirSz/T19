package com.songrequest.tida1601;

import static androidx.test.espresso.Espresso.onView;
import static androidx.test.espresso.action.ViewActions.click;
import static androidx.test.espresso.action.ViewActions.typeText;
import static androidx.test.espresso.assertion.ViewAssertions.matches;
import static androidx.test.espresso.matcher.ViewMatchers.withId;
import static androidx.test.espresso.matcher.ViewMatchers.withText;

import androidx.test.ext.junit.rules.ActivityScenarioRule;
import androidx.test.ext.junit.runners.AndroidJUnit4;
import androidx.test.filters.LargeTest;

import org.junit.Rule;
import org.junit.Test;
import org.junit.runner.RunWith;

@RunWith(AndroidJUnit4.class)
@LargeTest
public class MainActivityTest {

    @Rule
    public ActivityScenarioRule<MainActivity> activityRule =
            new ActivityScenarioRule<>(MainActivity.class);

    @Test
    public void testGreetingText() {

        // Użytkownik wpisuje imię i nazwisko
        onView(withId(R.id.editText))
                .perform(typeText("jan kowalski"));

        // Kliknięcie przycisku
        onView(withId(R.id.button))
                .perform(click());

        // Sprawdzenie wyniku
        onView(withId(R.id.txtResult))
                .check(matches(withText("Cześć Jan Kowalski !")));
    }
}
