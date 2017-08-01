// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let stopwatch = System.Diagnostics.Stopwatch.StartNew()

    Seq.unfold (fun (a,b) -> Some(a+b, (b, a+b))) (0, 1)
        |> Seq.takeWhile (fun x -> x < 4000000)
        |> Seq.toList
        |> Seq.filter (fun x-> x%2 = 0)
        |> Seq.sum
        //|> Seq.iter (printfn "%d, ")
        |> printfn "Total %d"

    stopwatch.Stop()

    printfn "Time: %fms" stopwatch.Elapsed.TotalMilliseconds
    0 // return an integer exit code
