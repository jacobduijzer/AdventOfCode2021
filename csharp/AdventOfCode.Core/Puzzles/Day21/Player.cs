namespace AdventOfCode.Core.Puzzles.Day21;

public class Player
{
    public int CurrentPosition => _currentPosition;
    public int Score => _score;
    
    private int _currentPosition;
    private int _score = 0;

   public Player(int startPosition)
   {
       _currentPosition = startPosition;
   }
   
   public void Move(int[] numbers)
   {
       var newPosition = ((_currentPosition + numbers.Sum() - 1) % 10) + 1;
       _score = Score + newPosition;
       _currentPosition = newPosition;
   }
}