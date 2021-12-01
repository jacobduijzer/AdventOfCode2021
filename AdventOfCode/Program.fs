open System
open AdventureOfCode.Puzzles

[<EntryPoint>]
let main argv =
    let welcomeMessage = Day00.welcomeMessage 0
    printfn $"%s{welcomeMessage}"
    let result1 = Day01.solvePart1 "Puzzles/Day01Input.txt"
    printfn $"result part 1: {result1}"
    let result2 = Day01.solvePart2 "Puzzles/Day01Input.txt"
    printfn $"result part 2: {result2}"
    Console.ReadLine() |> ignore
    0