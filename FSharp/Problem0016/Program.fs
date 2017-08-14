// Learn more about F# at http://fsharp.org

// Power digit sum
// Problem 16 
// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

// What is the sum of the digits of the number 21000?

open System

[<EntryPoint>]
let main argv =
    let raiseToPwr = 5
    let numWithRaiseToPwr = 2
    
    let resolveRaiseToPwr =
        let rec resolve limit currentPwr num =
            match num with
                | currentPwr when limit < 1 -> printfn "num: %d" num; num
                | currentPwr when currentPwr*2 > raiseToPwr -> printfn "1. limit: %d | pwr: %d | num: %d" (limit-currentPwr) 1 numWithRaiseToPwr; num * (resolve (limit-currentPwr) 1 numWithRaiseToPwr) 
                | _ -> printfn "2. limit: %d | pwr: %d | num: %d" limit (currentPwr*2) (num*num); resolve limit (currentPwr*2) (num*num)

        resolve raiseToPwr 1 numWithRaiseToPwr
    
    // let sumOfDig num: int64 =
    //     let rec loopDigs sum = function
    //          |  num when num > 0L -> loopDigs  (sum + (num%10L)) (num/10L)
    //          | _ -> sum

    //     loopDigs 0L num

    let digSum = resolveRaiseToPwr
                //|> sumOfDig

    printfn "Hello World from F#! %A" digSum

    0 // return an integer exit code
