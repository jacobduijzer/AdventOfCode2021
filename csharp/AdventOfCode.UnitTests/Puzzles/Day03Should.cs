using AdventOfCode.Core.Puzzles.Day03;
using Xunit;

namespace AdventOfCode.UnitTests.Puzzles;

public class Day03Should
{
    [Theory]
    [InlineData("testinput/day03.txt")]
    public void SolvePart1(string inputFile)
    {
        // ARRANGE
        var day03 = new Solution(inputFile);
        
        // ACT
        var result = day03.SolvePart1();
        
        // ASSERT
        Assert.NotNull(result);
    }
}