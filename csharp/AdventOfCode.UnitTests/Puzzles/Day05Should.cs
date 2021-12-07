using AdventOfCode.Core.Puzzles;
using Xunit;

namespace AdventOfCode.UnitTests.Puzzles;

public class Day05Should
{
    [Fact]
    public void SolvePart1Test()
    {
        // ARRANGE
        var day5 = new Day05();

        // ACT
        var result = day5.SolvePart1("Puzzles/Day05TestInput.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void SolvePart1()
    {
        // ARRANGE
        var day5 = new Day05();

        // ACT
        var result = day5.SolvePart1("Puzzles/Day05Input.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(7473, result);
    }
    
    [Fact]
    public void SolvePart2Test()
    {
        // ARRANGE
        var day5 = new Day05();

        // ACT
        var result = day5.SolvePart2("Puzzles/Day05TestInput.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(12, result);
    }
    
    [Fact]
    public void SolvePart2()
    {
        // ARRANGE
        var day5 = new Day05();

        // ACT
        var result = day5.SolvePart2("Puzzles/Day05Input.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(24164, result);
    }
}