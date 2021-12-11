namespace AdventOfCode.Core.Puzzles.Day11;

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