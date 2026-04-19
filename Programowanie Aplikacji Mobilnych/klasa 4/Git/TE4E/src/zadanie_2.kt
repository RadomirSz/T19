fun main() {
}

fun maxElement(tab: IntArray): Int {
    var max = tab[0]
    for (i in tab) {
        if (i > max) max = i
    }
    return max
}

fun minElement(tab: IntArray): Int {
    var min = tab[0]
    for (i in tab) {
        if (i < min) min = i
    }
    return min
}

fun viceMax(tab: IntArray): Int {
    var max = Int.MIN_VALUE
    var viceMax = Int.MIN_VALUE

    for (i in tab) {
        if (i > max) {
            viceMax = max
            max = i
        } else if (i > viceMax && i < max) {
            viceMax = i
        }
    }
    return viceMax
}

fun sumaElementow(tab: IntArray): Int {
    var suma = 0
    for (i in tab) {
        suma += i
    }
    return suma
}

fun sumaParzystych(tab: IntArray): Int {
    var suma = 0
    for (i in tab) {
        if (i % 2 == 0) suma += i
    }
    return suma
}

fun sumaNieparzystych(tab: IntArray): Int {
    var suma = 0
    for (i in tab) {
        if (i % 2 != 0) suma += i
    }
    return suma
}

fun czyPalindrom(tab: IntArray): Boolean {
    var i = 0
    var j = tab.size - 1

    while (i < j) {
        if (tab[i] != tab[j]) return false
        i++
        j--
    }
    return true
}

fun czySumaIndeksowRowna(tab: IntArray): Boolean {
    var sumaParzyste = 0
    var sumaNieparzyste = 0

    for (i in tab.indices) {
        if (i % 2 == 0) sumaParzyste += tab[i]
        else sumaNieparzyste += tab[i]
    }
    return sumaParzyste == sumaNieparzyste
}

fun czySkaczaca(tab: IntArray): Boolean {
    if (tab.size < 2) return true

    for (i in 1 until tab.size - 1) {
        if (!((tab[i] > tab[i - 1] && tab[i] > tab[i + 1]) ||
                    (tab[i] < tab[i - 1] && tab[i] < tab[i + 1]))) {
            return false
        }
    }
    return true
}

fun ileParzystych(tab: IntArray): Int {
    var licznik = 0
    for (i in tab) {
        if (i % 2 == 0) licznik++
    }
    return licznik
}
