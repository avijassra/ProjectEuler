// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let stopWatch = System.Diagnostics.Stopwatch.StartNew()

    let sum = [|1..999|]
                |> Array.filter (fun x -> x % 3 = 0 || x % 5 = 0)
                |> Array.sum
    
    stopWatch.Stop()

    printfn "Total %d (time %fms)" sum stopWatch.Elapsed.TotalMilliseconds 
    0 // return an integer exit code
