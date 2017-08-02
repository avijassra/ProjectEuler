// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let stopwatch = System.Diagnostics.Stopwatch.StartNew()
    
    let rec CalculatePrimeFactor  (num:int64) (lpf:int64) =
        match num with
            | _ when float lpf > Math.Sqrt(float num) -> num
            | _ when num%lpf = 0L -> CalculatePrimeFactor (num/lpf) 2L
            | _ -> CalculatePrimeFactor num (lpf+1L)

    let largestPrimeFactor = CalculatePrimeFactor 600851475143L 2L

    stopwatch.Stop()

    printfn "Largest Prime Factor: %d (time: %fms)" largestPrimeFactor stopwatch.Elapsed.TotalMilliseconds
    0 // return an integer exit code
