// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let gridSize = 2
    let oneArray = Array.create gridSize+1 nan
    let grid = Array.create gridSize+1 oneArray
    grid.[3].[3] <- 1.0

    for i in 0 .. gridSize do
    for j in 0 .. gridSize do
        printfn "grid[%d][%d] = %d" i j grid.[i].[j]


    //printfn "Hello World from F#!"
    0 // return an integer exit code
