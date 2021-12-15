using AdventOfCode.Core.Common;

namespace AdventOfCode.Core.Puzzles.Day15;


public class Solution : PuzzleBase
{
    private readonly int _maxColumns;

    private readonly int _maxRows;
    public Solution(string inputFile)
    {
        var lines = InputHelper.ReadLinesFromFile(inputFile);

        _maxRows = lines.Length;
        _maxColumns = lines[0].Length;
        for (var row = 0; row < _maxRows; row++)
        for (var column = 0; column < _maxColumns; column++)
            grid[row,column] = 
            // grid[row, column] = new Octopus(int.Parse(lines[row][column].ToString())); 
    }

   

    public override object SolvePart1()
    {
        throw new NotImplementedException();
    }

    public override object SolvePart2()
    {
        throw new NotImplementedException();
    }
}