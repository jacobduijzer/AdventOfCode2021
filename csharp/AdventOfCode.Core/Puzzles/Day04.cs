using AdventOfCode.Core.Puzzles.Day04Code;

namespace AdventOfCode.Core.Puzzles;

public class Day04
{
    private readonly int[] _bingoNumbers;
    private readonly string[] _cardInput;

    public Day04(string inputFile)
    {
        var input = File.ReadAllLines(inputFile);
        _bingoNumbers = input[0].Split(',').Select(x => int.Parse(x)).ToArray();
        _cardInput = input
            .Where(line => line != string.Empty)
            .Skip(1)
            .Take(input.Length - 1)
            .ToArray();
    }

    public object SolvePart1(string inputFile)
    {
        var numberOfCards = _cardInput.Length / 5;

        var gameService = new GameService();
        for (int i = 0; i < numberOfCards; i++)
            gameService.AddBingoCard(new BingoCard(_cardInput.Skip(i * 5).Take(5).ToArray()));

        foreach (var number in _bingoNumbers.ToList())
        {
            gameService.PlayNumber(number);
            if (gameService.HasWinner)
                break;
        }

        return gameService;
    }

    public object SolvePart2(string inputFile)
    {
        var numberOfCards = _cardInput.Length / 5;

        var gameService = new GameService();
        for (int i = 0; i < numberOfCards; i++)
            gameService.AddBingoCard(new BingoCard(_cardInput.Skip(i * 5).Take(5).ToArray()));

        foreach (var number in _bingoNumbers.ToList())
            gameService.PlayNumber(number);

        return gameService;
    }
}