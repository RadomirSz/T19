fun main() {}

fun euklidesOdejmowanie(a: Int, b: Int): Int {
    var x = kotlin.math.abs(a)
    var y = kotlin.math.abs(b)
    while (x != y) {
        if (x > y) x -= y
        else y -= x
    }
    return x
}

fun euklidesModulo(a: Int, b: Int): Int {
    var x = kotlin.math.abs(a)
    var y = kotlin.math.abs(b)

    while (y != 0) {
        val r = x % y
        x = y
        y = r
    }
    return x
}

fun fibonacciIteracyjnie(n: Int): Int {
    if (n <= 1) return n

    var a = 0
    var b = 1
    for (i in 2..n) {
        val c = a + b
        a = b
        b = c
    }
    return b
}

fun fibonacciRekurencyjnie(n: Int): Int {
    return if (n <= 1) n
    else fibonacciRekurencyjnie(n - 1) + fibonacciRekurencyjnie(n - 2)
}

fun silniaIteracyjnie(n: Int): Int {
    var wynik = 1
    for (i in 1..n) {
        wynik *= i
    }
    return wynik
}

fun silniaRekurencyjnie(n: Int): Int {
    return if (n <= 1) 1
    else n * silniaRekurencyjnie(n - 1)
}

fun horner(wspolczynniki: IntArray, x: Int): Int {
    var wynik = 0
    for (i in wspolczynniki) {
        wynik = wynik * x + i
    }
    return wynik
}

fun sumaCyfr(liczba: Int): Int {
    var n = kotlin.math.abs(liczba)
    var suma = 0

    while (n > 0) {
        suma += n % 10
        n /= 10
    }
    return suma
}

fun liczbyPierwsze(n: Int, m: Int): List<Int> {
    val wynik = mutableListOf<Int>()

    for (i in maxOf(2, n)..m) {
        var pierwsza = true
        for (j in 2..kotlin.math.sqrt(i.toDouble()).toInt()) {
            if (i % j == 0) {
                pierwsza = false
                break
            }
        }
        if (pierwsza) wynik.add(i)
    }
    return wynik
}

fun dzielnikiWPrzedziale(x: Int, k: Int, l: Int): List<Int> {
    val wynik = mutableListOf<Int>()

    for (i in k..l) {
        if (i != 0 && x % i == 0) {
            wynik.add(i)
        }
    }
    return wynik
}
