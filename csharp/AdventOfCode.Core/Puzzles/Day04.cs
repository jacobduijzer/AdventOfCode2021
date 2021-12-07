using AdventOfCode.Core.Puzzles.Day04Code;

namespace AdventOfCode.Core.Puzzles;

public class Day04
{
    public object SolvePart1(string inputFile)
    {
        var input = File.ReadAllLines(inputFile);

        var bingoNumbers = input[0].Split(',').Select(x => int.Parse(x)).ToArray();

        var cardInput = input
            .Where(line => line != string.Empty)
            .Skip(1)
            .Take(input.Length - 1)
            .ToArray();

        var numberOfCards = cardInput.Length / 5;

        var gameService = new GameService();
        for (int i = 0; i < numberOfCards; i++)
            gameService.AddBingoCard(new BingoCard(cardInput.Skip(i * 5).Take(5).ToArray()));

        foreach (var number in bingoNumbers.ToList())
        {
            gameService.PlayNumber(number);
            if (gameService.HasWinner)
                break;
        }

        return gameService;
    }

    public object SolvePart2(string inputFile)
    {
        var input = File.ReadAllLines(inputFile);

        var bingoNumbers = input[0].Split(',').Select(x => int.Parse(x)).ToArray();

        var cardInput = input
            .Where(line => line != string.Empty)
            .Skip(1)
            .Take(input.Length - 1)
            .ToArray();

        var numberOfCards = cardInput.Length / 5;

        var gameService = new GameService();
        for (int i = 0; i < numberOfCards; i++)
            gameService.AddBingoCard(new BingoCard(cardInput.Skip(i * 5).Take(5).ToArray()));

        foreach (var number in bingoNumbers.ToList())
            gameService.PlayNumber(number);

        return gameService;
    }
}