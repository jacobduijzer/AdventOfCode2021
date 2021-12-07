using System.Collections.Generic;
using AdventOfCode.Core.Puzzles;
using Xunit;

namespace AdventOfCode.UnitTests.Puzzles;

public class Day07Should
{
    [Fact]
    public void SolvePart1Test()
    {
        // ARRANGE
        var day7 = new Day07();

        // ACT
        var result = day7.SolvePart1("Puzzles/Day07TestInput.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(37, result);
    }

    [Fact]
    public void SolvePart1()
    {
        // ARRANGE
        var day7 = new Day07();

        // ACT
        var result = day7.SolvePart1("Puzzles/Day07Input.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(356990, result);
    }
    
    [Fact]
    public void SolvePart2Test()
    {
        // ARRANGE
        var day7 = new Day07();

        // ACT
        var result = day7.SolvePart2("Puzzles/Day07TestInput.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(168, result);
        
    }

    [Fact]
    public void SolvePart2()
    {
        // ARRANGE
        var day7 = new Day07();

        // ACT
        var result = day7.SolvePart2("Puzzles/Day07Input.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(101267361, result);
    }
}