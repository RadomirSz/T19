fun main() {
    z1()
    println("daj dwie liczby")
//    val a = readln().toInt()
//    val b = readln().toInt()
//    println(z2(a,b))
    println(z3(28))
    val lista = Array(4){i -> i+1}
    lista.shuffle()
    for(x in lista) print("$x")
    for(i in 0..<lista.size) print(lista[i])
    println()

    val bam = intArrayOf(5,1,7,2,6,7,6,7,6,7,3)
    bam.map { print(it) }
    val newList = z4(bam)
    println()
    newList.forEach { print(it) }

}
fun z1(){
    println("heloł")
}
fun z2(x: Int, y: Int) : Int{
    var a=x
    var b=y
    while (a!=b){
        if(a>b) a -= b
        if(b>a) b -= a
    }
    return a
}
fun z3(x:Int) : Boolean{
    var suma: Int = 0
    for (i in 1..x-1){
        if(x%i==0){
            suma += i
        }
    }
    return suma == x
}
fun z4(lista: IntArray): IntArray{
    var arr = lista
    val n = arr.size
    for (i in 0 .. n ) {
        var minIndex = i
        for (j in i + 1 until n) {
            if (arr[j] < arr[minIndex]) {
                minIndex = j
            }
        }
        if (minIndex != i) {
            val temp = arr[i]
            arr[i] = arr[minIndex]
            arr[minIndex] = temp
        }
    }
    return arr
}
fun z5(){//horner
}
//zad 6

//open class // mozna dziedziczyc
//data class // bazodanowa
//object class // singleton
//final class // domyslna // nie mozna po niej dziedziczyc

class Koszyk(private val Id : Int, var opis : String, var kwota: Float){}

class Faktura(val id:Int, var wartosc:Float){}

class Kurier(val id:Int, var nazwa:String){}

class Zamowienie(var koszyk : Koszyk, var faktura : Faktura, var Kurier : Kurier)

fun z6(){
        
}
