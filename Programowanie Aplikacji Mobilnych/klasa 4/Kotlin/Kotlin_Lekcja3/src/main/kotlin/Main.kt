fun main() {
    println(z1(12))
    println(z2(79.99f))
    println(z3(4))

    println("Daj liczby:")
    val T = readln().split(" ").map { it.toDouble() }.toList()
    val pierwiastekSumy = {T: List<Double> -> kotlin.math.sqrt(T.sum())}
    println(pierwiastekSumy(T))
}

fun z1(a:Int) = 100-a
fun z2(cena: Float) = cena*0.8
fun z3(f:Int) = f%2==0