using AdventOfCode.Core.Puzzles;
using Xunit;

namespace AdventOfCode.UnitTests.Puzzles;

public class Day11Should
{
    [Theory]
    [InlineData("testinput/day11.txt", 10, 10)]
    public void ParseInputToStartGrid(string filePath, int width, int height)
    {
        var day11 = new Day11(filePath);

        Assert.NotNull(day11.Grid);
        Assert.Equal(width, day11.MaxColumns);
        Assert.Equal(height, day11.MaxRows);
    }
    
    [Theory]
    [InlineData("testinput/day11.txt", 1, 0)]
    [InlineData("testinput/day11.txt", 2, 35)]
    [InlineData("testinput/day11.txt", 10, 204)]
    [InlineData("testinput/day11.txt", 100, 1656)]
    [InlineData("input/day11.txt", 100, 1725)]
    public void SolvePart1(string filePath, int numberOfRuns, int expectedNumberOfFlashes)
    {
        // ARRANGE
        var day11 = new Day11(filePath);

        // ACT
        var result = day11.SolvePart1(numberOfRuns);

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(expectedNumberOfFlashes, (int)result);
    }
    
    [Fact]
    
    public void SolvePart2()
    {
        // ARRANGE
        var day11 = new Day11("input/day11.txt");

        // ACT
        var result = day11.SolvePart2();

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(308, (int)result);
    }
}