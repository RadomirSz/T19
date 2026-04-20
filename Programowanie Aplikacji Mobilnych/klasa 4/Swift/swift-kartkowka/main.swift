
// vicemax
func vicemax(_ T:[Int]) -> Int {
    if T.count < 2 { return -1}
    var vice = Int.min
    var max = Int.min
    for i in T{
        if i > max{
            vice = max
            max = i
        }
        if i > vice && i < max{
            vice = i
        }
    }
    return vice
}

print(vicemax([2,4,36,7,4,3,6,567,2,435,134,6,54,234,1])) //435

func czypierwiastkowalna(_ n: Int) -> Bool{
    for i in 1..<n/2{
        if i*i == n{
            return true
        }
    }
    return false
}

print(czypierwiastkowalna(15)) // false
print(czypierwiastkowalna(16)) // true

func najdluzszyrosnacypodciag(_ T: [Int]) -> [Int] {
    
    var maxStart = 0, maxDlugosc = 1
    var aktualnyStart = 0, aktualnaDlugosc = 1
    
    for i in 1..<T.count {
        if T[i] > T[i - 1] {
            aktualnaDlugosc += 1
        } else {
            aktualnyStart = i
            aktualnaDlugosc = 1
        }
        
        if aktualnaDlugosc > maxDlugosc {
            maxDlugosc = aktualnaDlugosc
            maxStart = aktualnyStart
        }
    }
    
    return Array(T[maxStart..<maxStart + maxDlugosc])
}

print(najdluzszyrosnacypodciag([3, 1, 5, 2, 6, 7, 4, 9]))


