using System.Text;
using AdventOfCode.Core.Common;

namespace AdventOfCode.Core.Puzzles.Day13;

public class Solution : PuzzleBase
{
    private readonly Grid _grid;

    public Solution(string inputFile)
    {
        _grid = new Grid(InputHelper.ReadLinesFromFile(inputFile));
    }

    public override object SolvePart1()
    {
        return _grid.HandleFolds(new List<Fold> {_grid.Folds[0]}).Count;
    }

    public override object SolvePart2()
    {
        var newGrid = _grid.HandleFolds(_grid.Folds);

        var columns = newGrid.Max(p => p.X);
        var ro = newGrid.Max(p => p.Y);

        var sb = new StringBuilder();
        sb.AppendLine();

        for (var y = 0; y <= ro; y++)
        {
            for (var x = 0; x <= columns; x++)
                sb.Append(newGrid.Contains((x, y)) ? "█" : ".");

            sb.AppendLine();
        }

        return sb.ToString();
    }
}