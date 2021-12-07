namespace AdventureOfCode.Puzzles

open System
open System.IO

module Day07 =
    
    let triangularNumber n = (n*(n+1))/2

    let parseInput filePath =
        let numbers =
            File.ReadAllText filePath
            |> List.ofSeq
            |> List.map (Operators.int)

        numbers

    let solvePart1 filePath =
        let numbers = parseInput filePath
        let min = Seq.min numbers
        let max = Seq.max numbers

        let minimumFuelConsumption = 
            seq { min .. max }
            |> Seq.map
                (fun step ->
                    numbers
                    |> Seq.map (fun number -> Math.Abs(number - step))
                    |> Seq.sum)
            |> Seq.min
        minimumFuelConsumption 

    let solvePart2 filePath =
        let numbers = parseInput filePath
        Seq.min numbers