namespace AdventOfCode.Core.Puzzles.Day21;

public record Game(Player Player1, Player Player2)
{
    public bool HasWinner(int score) => 
        Player1.Score >= score || Player2.Score >= score;

    public void Play(int playerNumber, int[] numbers)
    {
        if(playerNumber == 0)
            Player1.Move(numbers);
        else
            Player2.Move(numbers);
    }
}