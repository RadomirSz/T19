# PROGRAMOWANIE DYNAMICZNE - NAJDŁUŻSZY WSPÓLNY PODCIĄG (LCS)

## Czym jest programowanie dynamiczne?

Programowanie dynamiczne (ang. dynamic programming) to technika algorytmiczna, która służy do rozwiązywania problemów optymalizacyjnych. Zamiast wielokrotnie rozwiązywać te same podproblemy, przechowuje ich wyniki i wykorzystuje je przy rozwiązywaniu większych problemów.

## Problem najdłuższego wspólnego podciągu (LCS)

Problem polega na znalezieniu najdłuższego ciągu, który jest podciągiem zarówno X, jak i Y.

**Definicje:**
- **Podciąg (subsequence)** - to ciąg, który możemy otrzymać z innego ciągu przez usunięcie niektórych (lub żadnych) elementów, bez zmiany kolejności pozostałych
- **n** - długość pierwszego ciągu
- **m** - długość drugiego ciągu
- **X[0..n-1]** - pierwszy ciąg
- **Y[0..m-1]** - drugi ciąg

**Przykład:**
Dla ciągów "ALGORYTMIKA" i "INFORMATYKA":
- LCS = "ORTKA" (długość 5)

## Algorytm LCS

### Krok 1: Tworzenie tablicy dynamicznej D

Tworzymy tablicę D[i][j], gdzie:
- D[i][j] = długość najdłuższego wspólnego podciągu dla pierwszych i znaków X i pierwszych j znaków Y

### Krok 2: Wzór rekurencyjny

```
D[i][j] = 0                           gdy i = 0 lub j = 0
D[i][j] = D[i-1][j-1] + 1            gdy X[i] == Y[j]
D[i][j] = max(D[i-1][j], D[i][j-1]) gdy X[i] != Y[j]
```

**Wyjaśnienie:**
1. Jeśli x[i] = y[j], to ostatnie znaki są równe, więc dodajemy je do najdłuższego wspólnego podciągu dla prefiksów X[1..i-1] i Y[1..j-1]
2. Jeśli x[i] ≠ y[j], to ostatnie znaki są różne, więc wybieramy maksymalną wartość z sąsiednich komórek (pomijamy jeden znak z X lub Y)

### Krok 3: Wypełnianie tablicy

Wypełniamy tablicę wiersz po wierszu, od lewej do prawej, stosując wzór rekurencyjny.

### Krok 4: Odtwarzanie wyniku

D[n][m] zawiera długość najdłuższego wspólnego podciągu.

Aby odtworzyć sam podciąg, cofamy się od D[n][m]:
- Jeśli X[i] == Y[j], to znak należy do LCS - zapisujemy go i przesuwamy się do D[i-1][j-1]
- Jeśli D[i-1][j] > D[i][j-1], przesuwamy się do D[i-1][j]
- W przeciwnym razie przesuwamy się do D[i][j-1]

## Złożoność czasowa

Algorytm ma złożoność O(n × m), gdzie:
- n to długość pierwszego ciągu
- m to długość drugiego ciągu

Jest to zdecydowanie lepsza złożoność niż naiwne rozwiązanie, które miałoby złożoność wykładniczą.

## Złożoność pamięciowa

Algorytm wymaga O(n × m) pamięci na przechowanie tablicy D.

## UWAGA: Różnica między LCS a najdłuższym wspólnym podciągiem ciągłym

**LCS (Longest Common Subsequence)** - elementy nie muszą być kolejno
Przykład: "ABCD" i "ACBD" → LCS = "ABD" (długość 3)

**Najdłuższy wspólny podciąg ciągły (Longest Common Substring)** - elementy muszą być kolejno
Przykład: "ABCD" i "ACBD" → LCS substring = "B" lub "D" (długość 1)

---

## ZADANIA WYKONANE:

**Zadanie 1** - zadanie1.py - Wyświetla macierz LCS dla słów PROGRAMY i ALGORYTMY
**Zadanie 2** - zadanie2.py - Wyświetla długość LCS dla dwóch ciągów liczb
**Zadanie 3** - zadanie3.py - Wyświetla najdłuższy wspólny podciąg jako liczby
**Zadanie 4** - zadanie4.py - Wyświetla długość LCS dla dwóch słów
**Zadanie 5** - zadanie5.py - Wyświetla najdłuższy wspólny podciąg dla dwóch słów
**Zadanie 6** - zadanie6.py - Znajduje pary słów z pliku z najdłuższym LCS
**Zadanie 8*** - zadanie8.py - Znajduje najdłuższy wspólny spójny podciąg (substring)

Wszystkie programy zostały przetestowane i działają poprawnie!

