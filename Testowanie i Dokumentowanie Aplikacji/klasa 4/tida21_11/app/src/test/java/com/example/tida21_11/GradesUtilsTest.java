package com.example.tida21_11;

import junit.framework.TestCase;

import org.junit.Test;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.ArrayList;

public class GradesUtilsTest extends TestCase {

    @Test
    public void testNormal() {
        List<Integer> grades = Arrays.asList(3,4,5);
        float avg = GradesUtils.average(grades);
        assertEquals(4.0f, avg);
    }

    @Test
    public void testEmpty() {
        List<Integer> grades = Collections.emptyList();
        float avg = GradesUtils.average(grades);
        assertEquals(0.0f, avg);
    }

    @Test
    public void testSingle() {
        List<Integer> grades = Collections.singletonList(5);
        float avg = GradesUtils.average(grades);
        assertEquals(5.0f, avg);
    }

    @Test
    public void testLargeNumbers() {
        List<Integer> grades = new ArrayList<>();
        grades.add(1000000000);
        grades.add(1000000000);
        float avg = GradesUtils.average(grades);
        assertEquals(1000000000.0f, avg);
    }
}
