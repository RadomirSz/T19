package com.example.tida21_11;

import java.util.List;

public class GradesUtils {

    public static float average(List<Integer> grades) {
        if (grades == null || grades.isEmpty()) return 0.0f;

        double sum = 0.0;
        for (int g : grades) {
            sum += g;
        }
        double avg = sum / grades.size();
        return (float) avg;
    }
}

