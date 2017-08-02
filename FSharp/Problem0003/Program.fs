// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let stopwatch = System.Diagnostics.Stopwatch.StartNew()
    let bigNumber: BigInteger = 600851475143
    Seq { for i in 2 .. bigNumber/2 -> i}
        |> Seq.iter ( printfn "%d " )
    0 // return an integer exit code
