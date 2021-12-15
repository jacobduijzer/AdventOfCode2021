using AdventOfCode.Core.Puzzles.Day11;
using Xunit;

namespace AdventOfCode.UnitTests.Puzzles;

public class Day11Should
{
    [Theory]
    [InlineData("TestInput/day11.txt", 10, 10)]
    public void ParseInputToGrid(string filePath, int width, int height)
    {
        var day11 = new Day11(filePath);

        Assert.NotNull(day11);
        Assert.Equal(width, day11.MaxColumns);
        Assert.Equal(height, day11.MaxRows);
    }
    
    [Theory]
    [InlineData("TestInput/day11.txt", 1656)]
    [InlineData("Input/day11.txt", 1725)]
    public void SolvePart1(string filePath, int expectedNumberOfFlashes)
    {
        // ARRANGE
        var day11 = new Day11(filePath);

        var result = day11.SolvePart1();

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(expectedNumberOfFlashes, (int)result);
    }
    
    [Fact]
    public void SolvePart2()
    {
        // ARRANGE
        var day11 = new Day11("Input/day11.txt");

        // ACT
        var result = day11.SolvePart2();

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(308, (int)result);
    }
}