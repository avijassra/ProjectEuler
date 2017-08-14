// Learn more about F# at http://fsharp.org

// Power digit sum
// Problem 16 
// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

// What is the sum of the digits of the number 21000?

open System

[<EntryPoint>]
let main argv =
    let stopwatch = System.Diagnostics.Stopwatch.StartNew()
    let raiseToPwr = 1000
    let numWithRaiseToPwr = 2I
    
    let resolveRaiseToPwr =
        let rec resolve limit currentPwr (num: bigint) : bigint =
            //printfn "limit: %d | currentPwr: %d | num: %A" limit currentPwr num
            match limit with
                | 0 -> 1I
                | limit when limit <= 1 -> num
                | limit when limit < (currentPwr*2) -> num * (resolve (limit-currentPwr) 1 numWithRaiseToPwr) 
                | _ -> resolve limit (currentPwr*2) (num*num)

        resolve raiseToPwr 1 numWithRaiseToPwr
    
    let sumOfDig (num:bigint) =
        let rec loopDigs sum = function
             |  num when num > 0I -> loopDigs  (sum + (num%10I)) (num/10I)
             | _ -> sum

        loopDigs 0I num

    let digSum = resolveRaiseToPwr
                    |> sumOfDig

    stopwatch.Stop()

    printfn "Power digit sum: %A (time: %dms)" digSum stopwatch.ElapsedMilliseconds

    0 // return an integer exit code
