using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using AdventOfCode.Core.Puzzles.Day17;
using Spectre.Console;

namespace AdventOfCode.ConsoleApplication.Puzzles;

public class Day17
{
    private readonly Solution _solution;

    public Day17(string inputFile)
    {
        _solution = new Solution(inputFile);
    }

    public async Task Run()
    {
        var hitCount = 0;
        var table = new Table()
            .Width(40)
            .Centered()
            .Title("Advent Of Code 2021 - Day 17")
            .AddColumn("")
            .AddColumn("");
        AnsiConsole.Clear();
        AnsiConsole
            .Live(table)
            .Start(ctx =>
            {
                var minXVelocity = (int) Math.Ceiling((Math.Sqrt(1 + _solution.Input.StartPoint.X * 8) - 1) / 2);

                for (var xVelocity = minXVelocity; xVelocity <= _solution.Input.EndPoint.X; xVelocity++)
                for (var yVelocity = (int) _solution.Input.EndPoint.Y;
                     yVelocity <= -_solution.Input.EndPoint.Y;
                     yVelocity++)
                {
                    var firingResult = _solution.FireProbe(new Vector2(xVelocity, yVelocity), out _);
                    if (firingResult.IsHit)
                        hitCount++;
                    table.Title($"Advent Of Code 2021 - Day 17 (hits: {hitCount})");
                    table.Rows.Clear();
                    foreach (var row in Enumerable.Range(-10, 31).Reverse())
                    {
                        StringBuilder sb = new();
                        foreach (var column in Enumerable.Range(0, 30))
                        {
                            if ((row == 0 && column == 0) || firingResult.Path.Contains(new Vector2(column, row)))
                            {
                                if (firingResult.IsHit)
                                    sb.Append("[green]#[/]");
                                else
                                    sb.Append("[red]#[/]");
                            }
                            else
                                sb.Append(".");
                        }

                        table.AddRow(row.ToString(), sb.ToString());
                    }

                    ctx.Refresh();
                    Thread.Sleep(50);
                }

            });

    }
}