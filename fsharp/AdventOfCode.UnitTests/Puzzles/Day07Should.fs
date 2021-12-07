module AdventOfCode.UnitTests.Puzzles.Day07Should

open AdventureOfCode.Puzzles
open Xunit

[<Fact>]
let ``Return the correct calculation for the example of part 1`` () =
    let result = Day07.solvePart1 "Puzzles/Day07TestInput.txt"
    Assert.NotNull(result)
    Assert.Equal(66, result)
    
    
[<Fact>]
let ``Return the correct calculation for part 1`` () =
    let result = Day07.solvePart1 "Puzzles/Day07Input.txt"
    Assert.NotNull(result)
    Assert.Equal(13933, result)
    
[<Fact>]
let ``Return the correct calculation for the example of part 2`` () =
    let result = Day07.solvePart2 "Puzzles/Day07TestInput.txt"
    Assert.NotNull(result)
    Assert.Equal(168, result)
    
    
[<Fact>]
let ``Return the correct calculation for part 2`` () =
    let result = Day07.solvePart2 "Puzzles/Day07Input.txt"
    Assert.NotNull(result)
    Assert.Equal(101268110, result)