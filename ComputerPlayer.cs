namespace RockPaperScissors;

/// <summary>
/// Concrete implementation of a computer player.
/// Demonstrates inheritance and polymorphism by providing computer-specific move selection.
/// </summary>
public class ComputerPlayer : Player
{
    private readonly Random _random;

    public ComputerPlayer(string name) : base(name)
    {
        _random = new Random();
    }

    /// <summary>
    /// Gets a random move from the computer player.
    /// Demonstrates polymorphic behavior - different implementation than HumanPlayer.
    /// </summary>
    public override Move GetMove()
    {
        int choice = _random.Next(1, 4);
        
        Move move = choice switch
        {
            1 => new Rock(),
            2 => new Paper(),
            3 => new Scissors(),
            _ => new Rock()
        };

        Console.WriteLine($"\n{Name} chose: {move}");
        return move;
    }
}
