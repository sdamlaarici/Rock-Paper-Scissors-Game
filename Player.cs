namespace RockPaperScissors;

/// <summary>
/// Abstract base class for all players in the game.
/// Demonstrates abstraction and polymorphism.
/// </summary>
public abstract class Player
{
    public string Name { get; }
    public int Score { get; set; }

    protected Player(string name)
    {
        Name = name;
        Score = 0;
    }

    /// <summary>
    /// Abstract method to get a move from the player.
    /// Derived classes implement different strategies (human input vs. computer random).
    /// </summary>
    /// <returns>The chosen move</returns>
    public abstract Move GetMove();
}
