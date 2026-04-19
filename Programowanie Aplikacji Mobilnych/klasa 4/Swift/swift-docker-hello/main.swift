import Foundation

// na kartkowke
// suma cyfr
func sumafycr(_ x: Int) -> Int {
    var a = x
    var suma: Int = 0
    while(a > 0){
        suma += a%10
        a /= 10
    }
    return suma
}
// czy jest pierwsza
func czypierwsza(_ x: Int) -> Bool{
    for i in 2..<(x/2){
        if(x%i == 0) {
            // print("nie pierwsza")
            return false
        }
    }
    // print("pierwsza")
    return true
}
// rozpietosc w tablicy max - min
func rozpietosc(tablica x:[Int]) -> Int{
    var min = Int.max
    var max = Int.min
    for i in x{
        if i > max {
            max = i
        }
        if i < min {
            min = i
        }
    }
    return max - min
}

// func euklides(a: Int, b: Int) -> Int {
//     while a != b {
//         if a > b {
//             a-=b
//         }
//         if b>a {
//             b-=a
//         }
//     }
//     return a
// }


func horner(_ coefficients: [Double], at x: Double) -> Double {
    var result = 0.0

    for coefficient in coefficients {
        result = result * x + coefficient
    }

    return result
}

func insertionSort(_ array: [Int]) -> [Int] {
    var sorted = array

    guard sorted.count > 1 else { return sorted }

    for i in 1..<sorted.count {
        let key = sorted[i]
        var j = i - 1

        while j >= 0 && sorted[j] > key {
            sorted[j + 1] = sorted[j]
            j -= 1
        }

        sorted[j + 1] = key
    }

    return sorted
}


// let coefficients = [2.0, -6.0, 2.0, -1.0]
// let x = 3.0
// let value = horner(coefficients, at: x)
// print("W(\(x)) = \(value)")


// let numbers = [5, 2, 9, 1, 5, 6]
// let sortedNumbers = insertionSort(numbers)
// print("Przed sortowaniem: \(numbers)")
// print("Po sortowaniu:     \(sortedNumbers)")
let a = 123
print(sumafycr(a)) // 6
print(czypierwsza(a)) // false

let T = [3,7,2,5,8,9,3,4,7] // min 2 max 9 rozpietosc 7
print(rozpietosc(tablica: T))