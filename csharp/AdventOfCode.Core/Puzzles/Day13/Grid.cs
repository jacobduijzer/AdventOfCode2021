using System.Text.RegularExpressions;

namespace AdventOfCode.Core.Puzzles.Day13;

public class Grid
{
    private int[,] _grid;
    private readonly int _maxRows;
    private readonly int _maxColumns;

    private Regex numberRegex = new Regex("(d+),(d)");
                                

    public Grid(string[] input)
    {
        foreach(var line in input)
            
        _maxRows = input.Length;
        _maxColumns = input[0].Length;
        
        for (var row = 0; row < _maxRows; row++)
        for (var column = 0; column < _maxColumns; column++)
            // grid[row, column] = new Octopus(int.Parse(lines[row][column].ToString()));
    }
}