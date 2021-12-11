using AdventOfCode.Core.Common;

namespace AdventOfCode.Core.Puzzles.Day03;

public class Solution : PuzzleBase<string[]>
{
    public Solution(string inputFile)
    {
        Input = ParseInput(File.ReadAllLines(inputFile));
    }

    public override object SolvePart1()
    {
        Dictionary<(int Position, int Number), int> numbers = new();
        for (var i = 0; i < Input[0].Length; i++)
        {
            var zero = Input
                .Select(x => x[i])
                .Count(y => y == '0');
            
            var one = Input
                .Select(x => x[i])
                .Count(y => y == '1');
            
            numbers.Add((i, 0), zero);
            numbers.Add((i, 1), one);
        }
        
        throw new NotImplementedException();
    }

    public override object SolvePart2()
    {
        throw new NotImplementedException();
    }

    public sealed override string[] ParseInput(string[] lines) => lines;
}