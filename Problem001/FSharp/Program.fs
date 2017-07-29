// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    [|1..999|]
        |> Array.filter (fun x -> x % 3 = 0 || x % 5 = 0)
        |> Array.sum
        |> printfn "Total %d" 
    0 // return an integer exit code
