// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    
    let stopwatch = System.Diagnostics.Stopwatch.StartNew()

    let collatzSeqGenerator (num: int64) = 
        match num with
            | num when num%2L = 0L -> (num/2L)
            | _ -> ((3L*num)+1L)

    let largetCollatzSeqStartingNumber num = 
        Seq.unfold (fun x -> Some(x, (collatzSeqGenerator x))) (num)
            |> Seq.takeWhile (fun x -> x > 1L)
            |> Seq.append [1L]
            |> Seq.toList
            |> Seq.length

    let (cl, num) = seq { 0L .. 1000000L }
                    |> Seq.map (fun x -> (largetCollatzSeqStartingNumber x, x)) 
                    |> Seq.max

    stopwatch.Stop()

    printfn "Largest Collatz chain is of %d for mnumber starting with: %d (time: %fms)" cl num stopwatch.Elapsed.TotalMilliseconds

    0 // return an integer exit code