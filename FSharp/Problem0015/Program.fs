// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let stopwatch = System.Diagnostics.Stopwatch.StartNew()
    let gridSize: int = 20
    let grid = Array2D.create (gridSize+1) (gridSize+1) 0L

    for i in 0 .. ((Array2D.length1 grid)-1) do
        Array2D.set grid gridSize i 1L
        Array2D.set grid i gridSize 1L

    for i in ((Array2D.length1 grid)-2) .. -1 .. 0 do
        for j in ((Array2D.length2 grid)-2) .. -1 .. 0 do
            Array2D.set grid i j (grid.[i, j+1] + grid.[i+1, j])

    stopwatch.Stop()

    printfn "Total Route Options: %d (time: %dms)" grid.[0, 0] stopwatch.ElapsedMilliseconds
    0 // return an integer exit code
