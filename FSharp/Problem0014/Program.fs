// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let stopwatch = System.Diagnostics.Stopwatch.StartNew()
    
    let collatzSeqGenerator n: int = 
        match n with
            | n when n = 1 -> None
            | n when n%2 = 0 -> (n/2)
            | _ -> (3n+1)

    let collatzSeq =  Seq.unfold (fun x -> Some(collatzSeqGenerator n, (collatzSeqGenerator n))) (13)

    collatzSeq
     |> Seq.iter (printfn "%d, ")

    
    stopwatch.Stop()

    //printfn "Largest Prime Factor: %d (time: %fms)" largestPrimeFactor stopwatch.Elapsed.TotalMilliseconds
    0 // return an integer exit code
