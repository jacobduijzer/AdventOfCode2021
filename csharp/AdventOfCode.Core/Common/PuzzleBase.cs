namespace AdventOfCode.Core.Common;

public abstract class PuzzleBase
{
    public abstract object SolvePart1();
    public abstract object SolvePart2();
}

public abstract class PuzzleBase<TInputType> : PuzzleBase
{
    protected TInputType Input { get; set; }
    
    public abstract TInputType ParseInput(string[] lines);
}