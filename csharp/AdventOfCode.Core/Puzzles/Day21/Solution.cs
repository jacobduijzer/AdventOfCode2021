using System.Text.RegularExpressions;
using AdventOfCode.Core.Common;

namespace AdventOfCode.Core.Puzzles.Day21;

public class Solution : PuzzleBase<Game>
{
    private readonly Dice _dice;

    public Solution(string inputFile) : base(inputFile)
    {
        _dice = new Dice();
    }

    public override object SolvePart1()
    {
        var player = 0;
        while (!Input.HasWinner(1000))
        {
            var numbers = _dice.Roll();
            Input.Play(player, numbers);
            player = (player + 1) % 2;
        }

        return Math.Min(Input.Player1.Score, Input.Player2.Score) * _dice.Rolled;
    }

    public override object SolvePart2()
    {
       
        return 0;
    }

    public override Game ParseInput(string inputFile)
    {
        var input = File.ReadLines(inputFile)
            .Select(x => Regex.Split(x, @"Player (\d+) starting position: (\d+)"))
            .Select(x => x.Where(y => !string.IsNullOrEmpty(y)));

        return new (
            new Player(int.Parse(input.First().ToArray()[1])), 
            new Player(int.Parse(input.Last().ToArray()[1])));
    }
}