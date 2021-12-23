using AdventOfCode.Core.Puzzles.Day17;
using Xunit;

namespace AdventOfCode.UnitTests.Puzzles;

public class Day17Should
{
    [Theory]
    [InlineData("TestInput/day17.txt", 40)]
    // [InlineData("Input/day15.txt", 388)]
    public void SolvePart1(string inputFile, int expectedResult)
    {
        // ARRANGE
        Solution day17 = new (inputFile);

        // ACT
        var result = day17.SolvePart1();

        // ASSERT
        Assert.NotNull(result);
    }
}