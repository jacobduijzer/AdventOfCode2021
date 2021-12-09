using AdventOfCode.Core.Puzzles;
using Xunit;

namespace AdventOfCode.UnitTests.Puzzles;

public class Day09Should
{
    [Theory]
    [InlineData("Puzzles/Day09TestInput.txt", 15)]
    [InlineData("Puzzles/Day09Input.txt", 566)]
    public void SolvePart1(string filePath, int expectedResult)
    {
        // ARRANGE
        var day9 = new Day09(filePath);

        // ACT
        var result = day9.SolvePart1();

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(expectedResult, result);
    } 
    
    [Theory]
    [InlineData("Puzzles/Day09TestInput.txt", 1134)]
    [InlineData("Puzzles/Day09Input.txt", 891684)]
    public void SolvePart2(string filePath, int expectedResult)
    {
        // ARRANGE
        var day9 = new Day09(filePath);

        // ACT
        var result = day9.SolvePart2();

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(expectedResult, result);
    } 
}