using AdventOfCode.Core.Puzzles.Day15;
using Xunit;

namespace AdventOfCode.UnitTests.Puzzles;

public class Day15Should
{
    [Theory]
    [InlineData("testinput/day15.txt", 40)]
    [InlineData("Input/day15.txt", 2891)]
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
    [InlineData("testinput/day15.txt", 1588)]
    [InlineData("Input/day15.txt", 2891)]
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