
fun main() {
    z1()
    z2()
    z3()
    z4()
    z5()
}

fun z1(){
    var suma = 0;
    for(i in 10..99){
        suma += i
    }
    println(suma)
}

fun z2(){
    println("daj liczbe")
    var n = readln().toInt()
    var suma = 0;
    while(n!=0){
        suma += n%10
        n /= 10
    }
    println(suma)
}

fun z3(){
    println("daj liczbe")
    var n = readln().toInt()
    var i = 0
    do
    {
        i++
        if(n%i==0) println(i)
    }while(i!=n)
}

fun z4(){
    println("daj liczbe")
    var n = readln().toInt()
    var T = mutableSetOf<Int>()
    var a = 0
    var b = 1
    var temp: Int
    for(i in 1..n){
        temp = a+b
        a = b
        b = temp
        T.add(a)
    }
    for(i in T) print("$i ")
    println()
}

fun z5(){
    println("daj 3 liczby")
    var x = readln().toInt()
    var y = readln().toInt()
    var z = readln().toInt()

    var mapaSilni = hashMapOf<Int,Int>()
    mapaSilni.put(x,silnia(x))
    mapaSilni.put(y,silnia(y))
    mapaSilni.put(z,silnia(z))
    mapaSilni.forEach { println("${it.key}: ${it.value}") }
}

fun silnia(n : Int) : Int{
    var wynik = 1
    for (i in 1..n){
        wynik*=i
    }
    return wynik
}