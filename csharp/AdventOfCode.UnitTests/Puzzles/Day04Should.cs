using System.Linq;
using AdventOfCode.Core.Puzzles;
using AdventOfCode.Core.Puzzles.Day04Code;
using Xunit;

namespace AdventOfCode.UnitTests.Puzzles;

public class Day04Should
{
    [Fact]
    public void SolvePart1Test()
    {
        // ARRANGE
        GameService result = (GameService)new Day04().SolvePart1("Puzzles/Day04TestInput.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(24, result.Winners.First().LastNumber);
        Assert.Equal(4512, result.Winners.First().GetScore());
    }
    
    [Fact]
    public void SolvePart1()
    {
        // ARRANGE
        GameService result = (GameService)new Day04().SolvePart1("Puzzles/Day04Input.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(95, result.Winners.First().LastNumber);
        Assert.Equal(72770, result.Winners.First().GetScore());
    }
    
    [Fact]
    public void SolvePart2Test()
    {
        // ARRANGE
        GameService result = (GameService)new Day04().SolvePart2("Puzzles/Day04TestInput.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(13, result.Winners.Last().LastNumber);
        Assert.Equal(1924, result.Winners.Last().GetScore());
    }
    
    [Fact]
    public void SolvePart2()
    {
        // ARRANGE
        GameService result = (GameService)new Day04().SolvePart2("Puzzles/Day04Input.txt");

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(47, result.Winners.Last().LastNumber);
        Assert.Equal(13912, result.Winners.Last().GetScore());
    }
}