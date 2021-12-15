using AdventOfCode.Core.Common;

namespace AdventOfCode.Core.Puzzles.Day15;

public class Solution : PuzzleBase
{
    private int[,] _grid;
    private readonly int _maxColumns;
    private readonly int _maxRows;

    /* 4 possible moves */
    // private readonly int[] _dx = {0, -1, 1, 0};
    // private readonly int[] _dy = {-1, 0, 0, 1};

    private readonly List<(int X, int Y)> _offsets = new()
    {
        (-1, 0), (0, -1), (0, 1), (1, 0)
    };

    record Cell(int Column, int Row, int Cost);

    public Solution(string inputFile)
    {
        var lines = InputHelper.ReadLinesFromFile(inputFile);

        _maxRows = lines.Length;
        _maxColumns = lines[0].Length;
        _grid = new int[_maxRows, _maxColumns];

        for (var row = 0; row < _maxRows; row++)
        for (var column = 0; column < _maxColumns; column++)
            _grid[row, column] = int.Parse(lines[row][column].ToString());
    }

    public override object SolvePart1() =>
        MinCost(_grid, _maxColumns, _maxRows);

    public override object SolvePart2()
    {
        throw new NotImplementedException();
    }

    private int MinCost(int[,] grid, int lastX, int lastY)
    {
        var tempGrid = new int[_maxColumns, _maxRows];

        var visited = new bool[_maxColumns, _maxRows];

        for (var column = 0; column < _maxColumns; column++)
        for (var row = 0; row < _maxRows; row++)
        {
            tempGrid[column, row] = int.MaxValue;
            visited[column, row] = false;
        }

        List<Cell> queue = new();

        tempGrid[0, 0] = grid[0, 0];

        queue.Add(new Cell(0, 0, grid[0, 0]));

        while (queue.Count > 0)
        {
            var cell = queue.First();
            queue.Remove(cell);
            var column = cell.Column;
            var row = cell.Row;

            if (visited[row, column])
                continue;

            visited[row, column] = true;

            foreach (var (nextColumn, nextRow) in _offsets
                         .Select(x => (X: x.X + column, Y: x.Y + row))
                         .Where(x => GridHelper.IsValidPoint(x.X, x.Y, _maxColumns, _maxRows)))
            {
                tempGrid[nextRow, nextColumn] = Math.Min(tempGrid[nextRow, nextColumn], tempGrid[row, column] + _grid[nextRow, nextColumn]);
                queue.Add(new Cell(nextColumn, nextRow, tempGrid[nextRow, nextColumn]));
            }
        }

        return tempGrid[_maxRows - 1, _maxColumns - 1] - tempGrid[0, 0];
    }
}