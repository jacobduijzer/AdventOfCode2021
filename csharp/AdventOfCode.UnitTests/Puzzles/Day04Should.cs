using System.Linq;
using AdventOfCode.Core.Puzzles;
using AdventOfCode.Core.Puzzles.Day04Code;
using Xunit;

namespace AdventOfCode.UnitTests.Puzzles;

public class Day04Should
{
    [Theory]
    [InlineData("testinput/day04.txt", 24, 4512)]
    [InlineData("input/day04.txt", 95, 72770)]
    public void SolvePart1(string filePath, int lastNumber, int score)
    {
        // ARRANGE
        var day04 = new Day04(filePath);
        
        // ACT
        GameService result = (GameService)day04.SolvePart1(filePath);

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(lastNumber, result.Winners.First().LastNumber);
        Assert.Equal(score, result.Winners.First().GetScore());
    }
    
    [Theory]
    [InlineData("testinput/day04.txt", 13, 1924)]
    [InlineData("input/day04.txt", 47, 13912)]
    public void SolvePart2(string filePath, int lastNumber, int score)
    {
        // ARRANGE
        var day04 = new Day04(filePath);
            
        // ACT
        GameService result = (GameService)day04.SolvePart2(filePath);
        
        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(lastNumber, result.Winners.Last().LastNumber);
        Assert.Equal(score, result.Winners.Last().GetScore());
    }
}