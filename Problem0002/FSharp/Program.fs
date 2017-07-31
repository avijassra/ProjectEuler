// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let fabSeq = Seq.unfold (fun(a,b) -> Some (a+b (b, a+b)) ) (0, 1)
    
    printfn "Hello World from F#!"
    0 // return an integer exit code
