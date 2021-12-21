namespace AdventOfCode.Core.Puzzles.Day21;

public class Player
{
    public readonly int Number;
    public int CurrentPosition => _currentPosition;
    public int Score => _score;
    
    private int _currentPosition;
    private int _max = 10;
    private int _score = 0;

   public Player(int number, int startPosition)
   {
       _currentPosition = startPosition;
       Number = number;
   }
   
   public void Move(int[] numbers)
   {
       var score = numbers.Sum();
       var steps = score % _max;
       var rounds = score / _max;
       if (_currentPosition + steps > _max)
       {
           var move = _max - _currentPosition;
           var remain = steps - move;
           _currentPosition = remain;
       }
       else
           _currentPosition += steps;
       _score += _currentPosition;
   }
}