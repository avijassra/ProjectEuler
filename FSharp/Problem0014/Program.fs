// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let stopwatch = System.Diagnostics.Stopwatch.StartNew()
    
    let collatzSeqGenerator (num: int) = 
        match num with
            | num when num%2 = 0 -> (num/2)
            | _ -> ((3*num)+1)

    let largetCollatzSeqStartingNumber num = 
        Seq.unfold (fun x -> Some(x, (collatzSeqGenerator x))) (num)
            |> Seq.takeWhile (fun x -> x > 1)
            |> Seq.append [1]
            |> Seq.toList
            |> Seq.length

    seq { 0 .. 100 }
        |> Seq.map (fun x -> KeyValue x, largetCollatzSeqStartingNumber)
        |> Seq iter (printfn "%A" )        
        

    stopwatch.Stop()

    //printfn "Largest Prime Factor: %d (time: %fms)" largestPrimeFactor stopwatch.Elapsed.TotalMilliseconds
    0 // return an integer exit code
