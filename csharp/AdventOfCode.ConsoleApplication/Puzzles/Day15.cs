using System.Text;
using AdventOfCode.Core.Common;
using AdventOfCode.Core.Puzzles.Day15;
using Spectre.Console;

namespace AdventOfCode.ConsoleApplication.Puzzles;

public class Day15
{
    private readonly Solution _solution;

    public Day15(string inputFile)
    {
        _solution = new Solution(inputFile);
    }

    public void Run()
    {
        var result = (PathFinderResult) _solution.SolvePart1();

        var width = result.StartGrid.Max(x => x.Key.X);
        var height = result.StartGrid.Max(x => x.Key.Y);

        var table = new Table()
            .Width(200)
            .Centered()
            .AddColumn("Advent Of Code 2021 - Day 15");

        AnsiConsole.Clear();
        AnsiConsole
            .Live(table)
            .Start(ctx =>
            {
                foreach (var row in Enumerable.Range(0, height))
                {
                    StringBuilder sb = new();
                    foreach (var column in Enumerable.Range(0, width))
                    {
                        if ((row == 0 && column == 0) || result.Path.Contains(new Point(row, column)))
                            sb.Append($"[aqua]{result.StartGrid[new Point(row, column)]}[/]");
                        else
                            sb.Append(result.StartGrid[new Point(row, column)]);
                    }

                    table.AddRow(sb.ToString());
                    ctx.Refresh();
                }
            });
    }
}