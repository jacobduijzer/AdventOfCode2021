using AdventOfCode.Core.Common;

namespace AdventOfCode.Core.Puzzles.Day15;

public class Solution : PuzzleBase<Dictionary<Point, int>>
{
    public Solution(string inputFile) => 
        Input = ParseInput(InputHelper.ReadLinesFromFile(inputFile));

    public override object SolvePart1() => 
        MinCost(Input);

    public override object SolvePart2() => 
        MinCost(EnlargeGrid(Input));

    private int MinCost(Dictionary<Point, int> grid)
    {
        var startPoint = new Point(0, 0);
        var endPoint = new Point(grid.Keys.MaxBy(p => p.X)!.X, grid.Keys.MaxBy(p => p.Y)!.Y);

        var queue = new PriorityQueue<Point, int>();
        var calculatedGrid = new Dictionary<Point, int>
        {
            [startPoint] = 0
        };

        queue.Enqueue(startPoint, 0);

        while (queue.Count > 0)
        {
            var currentPoint = queue.Dequeue();

            foreach (var nextPoint in GetNeighbours(currentPoint))
            {
                if (!grid.ContainsKey(nextPoint) || calculatedGrid.ContainsKey(nextPoint))
                    continue;

                var totalRisk = calculatedGrid[currentPoint] + grid[nextPoint];
                calculatedGrid[nextPoint] = totalRisk;
                if (nextPoint == endPoint)
                    break;

                queue.Enqueue(nextPoint, totalRisk);
            }
        }

        return calculatedGrid[endPoint];
    }

    private Dictionary<Point, int> EnlargeGrid(Dictionary<Point, int> grid)
    {
        var (columnCount, rowCount) = (grid.Keys.MaxBy(p => p.X)!.X + 1, grid.Keys.MaxBy(p => p.Y)!.Y + 1);

        Dictionary<Point, int> enlargedGrid = new();
        
        foreach(var column in Enumerable.Range(0, rowCount * 5))
        foreach (var row in Enumerable.Range(0, columnCount * 5))
        {
            var cellY = row % rowCount;
            var cellX = column % columnCount;
            var cellRiskLevel = grid[new Point(cellX, cellY)];
            var cellDistance = (row / rowCount) + (column / rowCount);
            var riskLevel = (cellRiskLevel + cellDistance - 1) % 9 + 1;
            enlargedGrid.Add(new Point(column, row), riskLevel);
        }

        return enlargedGrid;
    }
    
    IEnumerable<Point> GetNeighbours(Point point) =>
        new[]
        {
            point with {Y = point.Y + 1},
            point with {Y = point.Y - 1},
            point with {X = point.X + 1},
            point with {X = point.X - 1},
        };

    public sealed override Dictionary<Point, int> ParseInput(string[] lines)
    {
        var grid = new Dictionary<Point, int>();
        foreach (var y in Enumerable.Range(0, lines[0].Length))
        foreach (var x in Enumerable.Range(0, lines.Length))
            grid.Add(new Point(x, y), lines[x][y] - '0');

        return grid;
    }
}