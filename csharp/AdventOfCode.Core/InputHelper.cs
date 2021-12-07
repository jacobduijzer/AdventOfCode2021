namespace AdventOfCode.Core;

public static class InputHelper
{
    public static string[] ReadLinesFromFile(string file) =>
        File.ReadAllLines(file);
}