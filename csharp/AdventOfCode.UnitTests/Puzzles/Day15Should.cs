using AdventOfCode.Core.Puzzles.Day15;
using Xunit;

namespace AdventOfCode.UnitTests.Puzzles;

public class Day15Should
{
    [Theory]
    [InlineData("TestInput/day15.txt", 40)]
    [InlineData("Input/day15.txt", 388)]
    public void SolvePart1(string inputFile, int expectedResult)
    {
        // ARRANGE
        var day15 = new Solution(inputFile);

        // ACT
        var result = day15.SolvePart1();

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(expectedResult, result);
    }
    
    [Theory]
    [InlineData("TestInput/day15.txt", 315)]
    [InlineData("Input/day15.txt", 2819)]
    public void SolvePart2(string inputFile, int expectedResult)
    {
        // ARRANGE
        var day15 = new Solution(inputFile);

        // ACT
        var result = day15.SolvePart2();

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(expectedResult, result);
    }
}