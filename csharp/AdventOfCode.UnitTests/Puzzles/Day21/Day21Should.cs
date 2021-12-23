using AdventOfCode.Core.Puzzles.Day21;
using Xunit;

namespace AdventOfCode.UnitTests.Puzzles;

public class Day21Should
{
    [Theory]
    [InlineData("TestInput/day21.txt", 739785)]
    [InlineData("Input/day21.txt", 995904)]
    public void SolvePart1(string inputFile, int expectedResult)
    {
        // ARRANGE
        Solution day21 = new (inputFile);

        // ACT
        var result = day21.SolvePart1();

        // ASSERT
        Assert.NotNull(result);
        Assert.Equal(expectedResult, result);
    } 
}