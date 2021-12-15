using AdventOfCode.Core.Common;

namespace AdventOfCode.Core.Puzzles.Day07;

public class Solution : PuzzleBase
{
    private readonly int[] _positions;

    public Solution(string inputFile)
    {
        var input = InputHelper.ReadLinesFromFile(inputFile);
        _positions = input[0].Split(',').Select(int.Parse).ToArray(); 
    }
    
    public override object SolvePart1() =>
        Enumerable
            .Range(_positions.Min(), _positions.Max())
            .Select(number => _positions.Sum(item => Math.Abs(number - item)))
            .Prepend(int.MaxValue)
            .Min();

    public override object SolvePart2() => 
        Enumerable
            .Range(_positions.Min(), _positions.Max())
            .Select(number => _positions.Select(item => Math.Abs(number - item))
                .Select(distance => distance * (distance + 1) / 2)
                .Sum())
            .Prepend(int.MaxValue)
            .Min();
}