using System.Text.RegularExpressions;
using AdventOfCode.Core.Common;

namespace AdventOfCode.Core.Puzzles.Day21;

public class Solution : PuzzleBase<(Player Player1, Player Player2)>
{
    private readonly Dice _dice;

    public Solution(string inputFile) : base(inputFile)
    {
        _dice = new Dice();
    }

    public override object SolvePart1()
    {
        bool stopPlaying = false;
        while (!stopPlaying)
        {
            var numbers = _dice.Roll();
            Input.Player1.Move(numbers);

            if (Input.Player1.Score >= 1000)
            {
                stopPlaying = true;
                continue;
            }
            
            numbers = _dice.Roll();
            Input.Player2.Move(numbers);
            
            if (Input.Player2.Score >= 1000)
            {
                stopPlaying = true;
                continue;
            }
        }

        return Math.Min(Input.Player1.Score, Input.Player2.Score) * _dice.Rolled;
    }

    public override object SolvePart2()
    {
        throw new NotImplementedException();
    }

    public override (Player Player1, Player Player2) ParseInput(string inputFile)
    {
        var input = File.ReadLines(inputFile)
            .Select(x => Regex.Split(x, @"Player (\d+) starting position: (\d+)"))
            .Select(x => x.Where(y => !string.IsNullOrEmpty(y)));

        return (
            new Player(1, int.Parse(input.First().ToArray()[1])), 
            new Player(2, int.Parse(input.Last().ToArray()[1])));
    }
}