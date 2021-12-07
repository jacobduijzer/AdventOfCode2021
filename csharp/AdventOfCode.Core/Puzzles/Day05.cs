namespace AdventOfCode.Core.Puzzles;

public class Day05
{
    public object SolvePart1(string inputFile)
    {
        var input = InputHelper.ReadLinesFromFile(inputFile);
        var coords = CreateCoordinatesFromInput(input);
        Func<Line, bool> check = coord => coord.Start.X != coord.End.X && coord.Start.Y != coord.End.Y;

        var map = AddCoordinatesToMap(coords, check);

        return map.Count(x => x.Value >= 2);
    }

    public object SolvePart2(string inputFile)
    {
        var input = InputHelper.ReadLinesFromFile(inputFile);
        var coords = CreateCoordinatesFromInput(input);
        var map = AddCoordinatesToMap(coords, coord => false);
        return map.Count(x => x.Value >= 2);
    }

    private Dictionary<Point, int> AddCoordinatesToMap(
        IEnumerable<Line> coords,
        Func<Line, bool> extraCheck)
    {
        var map = new Dictionary<Point, int>();

        foreach (var coord in coords)
        {
            if (extraCheck(coord))
                continue;

            var yDiff = Math.Sign(coord.End.Y - coord.Start.Y);
            var xDiff = Math.Sign(coord.End.X - coord.Start.X);

            for (int x = coord.Start.X, y = coord.Start.Y;
                 x != coord.End.X + xDiff || y != coord.End.Y + yDiff;
                 x += xDiff, y += yDiff)
            {
                if (map.ContainsKey(new Point(x, y)))
                    map[new Point(x, y)]++;
                else
                    map.Add(new Point(x, y), 1);
            }
        }

        return map;
    }

    private IEnumerable<Line> CreateCoordinatesFromInput(string[] input) =>
        input
            .Select(x => x.Split(" -> "))
            .Select(CreateLine);

    private Line CreateLine(string[] input)
    {
        var point1 = new Point(int.Parse(input[0].Split(',')[0]), int.Parse(input[0].Split(',')[1]));
        var point2 = new Point(int.Parse(input[1].Split(',')[0]), int.Parse(input[1].Split(',')[1]));
        return new Line(point1, point2);
    }
}

public record Line(Point Start, Point End);

public record Point(int X, int Y);