using System.Collections.Generic;
using AdventOfCode.Core.Puzzles.Day21;
using Xunit;

namespace AdventOfCode.UnitTests.Puzzles;

public class PlayerShould
{
    [Theory]
    [InlineData(1)]
    public void StartWithCorrectStartPosition(int startPosition)
    {
        Player player = new(1, startPosition);

        Assert.Equal(startPosition, player.CurrentPosition);
    }

    [Theory]
    [InlineData(4, new[] {1, 2, 3}, 10)]
    [InlineData(4, new[] {1, 2, 3, 7, 8, 9}, 4)]
    [InlineData(4, new[] {1, 2, 3, 7, 8, 9, 13, 14, 15}, 6)]
    public void MoveToCorrectPosition(int startPosition, int[] rolls, int expectedPosition)
    {
        // ARRANGE
        Player player = new(1, startPosition);

        // ACT
        player.Move(rolls);

        // ASSERT
        Assert.Equal(expectedPosition, player.CurrentPosition);
    }
    
    [Theory]
    [MemberData(nameof(Data))]
    public void Score(int startPosition, List<int[]> rolls, int expectedScore)
    {
        // ARRANGE
        Player player = new(1, startPosition);

        // ACT
        foreach(var roll in rolls)
            player.Move(roll);

        // ASSERT
        Assert.Equal(expectedScore, player.Score);
    }
    
    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[]
            {
                4, new List<int[]>
                {
                    new[] {1, 2, 3} 
                },
                10
            },
            new object[]
            {
                4, 
                new List<int[]>
                {
                    new[] {1, 2, 3},
                    new[] {7, 8, 9},
                },
                14
            },
            new object[]
            {
                4, 
                new List<int[]>
                {
                    new[] {1, 2, 3},
                    new[] {7, 8, 9},
                    new[] {13, 14, 15},
                },
                20
            },
            
        };
}