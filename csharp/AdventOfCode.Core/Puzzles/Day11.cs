namespace AdventOfCode.Core.Puzzles;

public class Day11
{
    public readonly Octopus[,] Grid;
    public readonly int MaxRows;
    public readonly int MaxColumns;

    private readonly List<(int X, int Y)> _offsets = new() 
    {
        (-1, -1), (-1, 0), (-1, 1),
        (0, -1), (0, 1),
        (1, -1), (1, 0), (1, 1)
    };

    public Day11(string inputFile)
    {
        var lines = InputHelper.ReadLinesFromFile(inputFile);

        MaxRows = lines.Length;
        MaxColumns = lines[0].Length;

        Grid = new Octopus[MaxRows, MaxColumns];
        for (var row = 0; row < MaxRows; row++)
        for (var column = 0; column < MaxColumns; column++)
            Grid[row, column] = new Octopus(int.Parse(lines[row][column].ToString()));
    }

    public object SolvePart1(int numberOfRuns)
    {
        var numberOfFlashes = 0;

        for (int run = 0; run < numberOfRuns; run++)
        {
            Queue<(int X, int Y)> queue = new();
            ISet<(int X, int Y)> flashedOctopi = new HashSet<(int X, int Y)>();

            IncrementEnergyLevels(queue, flashedOctopi);
            HandleFlashes(queue, flashedOctopi);
            numberOfFlashes += flashedOctopi.Count;
        }

        return numberOfFlashes;
    }

    public object SolvePart2()
    {
        var step = 0;

        while(true)
        {
            Queue<(int X, int Y)> queue = new();
            ISet<(int X, int Y)> flashedOctopi = new HashSet<(int X, int Y)>();

            IncrementEnergyLevels(queue, flashedOctopi);
            HandleFlashes(queue, flashedOctopi);

            step++;
            if (flashedOctopi.Count == MaxRows * MaxColumns)
                break;
        }

        return step;
    }

    private void IncrementEnergyLevels(Queue<(int X, int Y)> queue, ISet<(int X, int Y)> flashedOctopi)
    {
        for (var row = 0; row < MaxRows; row++)
        for (var column = 0; column < MaxColumns; column++)
            if (Grid[row, column].IncreaseLevel() > 9)
            {
                queue.Enqueue((column, row));
                flashedOctopi.Add((column, row));
            }
    }
    
    private void HandleFlashes(Queue<(int X, int Y)> queue, ISet<(int X, int Y)> flashedOctopi)
    {
        while (queue.Count > 0)
        {
            var flashingOctopus = queue.Dequeue();
            Grid[flashingOctopus.Y, flashingOctopus.X].Reset();

            foreach (var neighbour in _offsets
                         .Select(x => (X: x.X + flashingOctopus.X, Y: x.Y + flashingOctopus.Y))
                         .Where(x => IsValidPoint(x.X, x.Y)))
            {
                if (flashedOctopi.Contains(neighbour)) continue;
                if (Grid[neighbour.Y, neighbour.X].IncreaseLevel() <= 9) continue;
                
                queue.Enqueue(neighbour);
                flashedOctopi.Add(neighbour);
            }
        }
    }
    
    private bool IsValidPoint(int column, int row) =>
        0 <= column && column < MaxColumns && 0 <= row && row < MaxRows;
}

public class Octopus
{
    private int _level = 0;

    public Octopus(int startValue) => _level = startValue;

    public int IncreaseLevel()
    {
        _level++;
        return _level;
    }

    public void Reset() => _level = 0;
}