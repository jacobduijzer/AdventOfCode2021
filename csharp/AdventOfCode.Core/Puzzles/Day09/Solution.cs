using AdventOfCode.Core.Common;

namespace AdventOfCode.Core.Puzzles.Day09;

public class Solution : PuzzleBase
{
    private readonly int[,] _input;
    private readonly int _max_y;
    private readonly int _max_x;

    private readonly List<(int X, int Y)> _offsets = new List<(int X, int Y)> {(-1, 0), (0, 1), (0, -1), (1, 0)};

    public Solution(string inputFile)
    {
        var lines = InputHelper.ReadLinesFromFile(inputFile);
        _max_y = lines.Length;
        _max_x = lines[0].Length;

        _input = new int[_max_y, _max_x];
        for (var y = 0; y < _max_y; y++)
        for (var x = 0; x < _max_x; x++)
            _input[y, x] = int.Parse(lines[y][x].ToString());
    }

    public override object SolvePart1()
    {
        var numbers = FindLowPoints();
        return numbers.Select(x => x.Value + 1).Sum();
    }

    public override object SolvePart2()
    {
        var lowPoints = FindLowPoints();
        return lowPoints
            .Select(lowPoint => GetBasinSize((lowPoint.Key.X, lowPoint.Key.Y)))
            .OrderByDescending(x => x).Take(3).Aggregate((x, y) => x * y);
    }

    private int GetBasinSize((int X, int Y) coord)
    {
        var queue = new List<(int X, int Y)> {coord};
        var visited = new List<(int X, int Y)>();
        while (queue.Count > 0)
        {
            var current = queue.First();
            visited.Add(current);
            queue.RemoveAt(0);
            var neighbours = _offsets
                .Select(x => (X: x.X + current.X, Y: x.Y + current.Y))
                .Where(x => IsValidPoint(x.X, x.Y) && _input[x.Y, x.X] != 9 && !visited.Contains(x) && !queue.Contains(x)).ToList();
            queue = queue.Concat(neighbours).ToList();
        }

        return visited.Count;
    }

    private Dictionary<(int X, int Y), int> FindLowPoints()
    {
        Dictionary<(int X, int Y), int> numbers = new();

        for (var y = 0; y < _max_y; y++)
        for (var x = 0; x < _max_x; x++)
        {
            var neighbours = _offsets
                .Select(point => (X: point.X + x, Y: point.Y + y))
                .Where(newPoint => IsValidPoint(newPoint.X, newPoint.Y))
                .ToList();
            
            if (neighbours.All(point => _input[point.Y, point.X] > _input[y, x]))
                numbers.Add((x, y), _input[y, x]);
        }

        return numbers;
    }

    private bool IsValidPoint(int x, int y) =>
        0 <= x && x < _max_x && 0 <= y && y < _max_y;
}