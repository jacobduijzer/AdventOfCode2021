namespace AdventOfCode.Core.Puzzles;

public class Day07
{
    public object SolvePart1(string inputFile)
    {
        var input = InputHelper.ReadLinesFromFile(inputFile);
        var positions = input[0].Split(',').Select(int.Parse).ToArray();

        return Enumerable
            .Range(positions.Min(), positions.Max())
            .Select(number => positions.Sum(item => Math.Abs(number - item)))
            .Prepend(int.MaxValue)
            .Min();
    }

    public object SolvePart2(string inputFile)
    {
        var input = InputHelper.ReadLinesFromFile(inputFile);
        var positions = input[0].Split(',').Select(int.Parse).ToArray();

        return Enumerable
            .Range(positions.Min(), positions.Max())
            .Select(number => positions.Select(item => Math.Abs(number - item))
                .Select(distance => distance * (distance + 1) / 2)
                .Sum())
            .Prepend(int.MaxValue)
            .Min();
    }

}