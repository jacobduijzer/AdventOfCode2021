using AdventOfCode.Core.Puzzles;
using Xunit;

namespace AdventOfCode.UnitTests.Puzzles;

public class Day08Should
{
    [Fact]
    public void SolvePart1Test()
    {
        // ARRANGE
        var day8 = new Day08();

        // ACT
        var result = day8.SolvePart1("Puzzles/Day08TestInput.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(26, result);
    }

    [Fact]
    public void SolvePart1()
    {
        // ARRANGE
        var day8 = new Day08();

        // ACT
        var result = day8.SolvePart1("Puzzles/Day08Input.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(521, result);
    }
    
    [Fact]
    public void SolvePart2Test01()
    {
        // ARRANGE
        var day8 = new Day08();

        // ACT
        var result = day8.SolvePart2("Puzzles/Day08TestInputPart2.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(5353, result);
    }
    
    [Fact]
    public void SolvePart2Test02()
    {
        // ARRANGE
        var day8 = new Day08();

        // ACT
        var result = day8.SolvePart2("Puzzles/Day08TestInput.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(61229, result);
    }

    [Fact]
    public void SolvePart2()
    {
        // ARRANGE
        var day8 = new Day08();

        // ACT
        var result = day8.SolvePart2("Puzzles/Day08Input.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(1016804, result);
    }
}