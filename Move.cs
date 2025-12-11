namespace RockPaperScissors;

/// <summary>
/// Abstract base class for all moves in the game.
/// Demonstrates abstraction and provides a contract for derived move classes.
/// </summary>
public abstract class Move
{
    public string Name { get; }

    protected Move(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Abstract method to determine if this move beats another move.
    /// Derived classes must implement this comparison logic.
    /// </summary>
    /// <param name="other">The move to compare against</param>
    /// <returns>True if this move beats the other move</returns>
    public abstract bool Beats(Move other);

    public override string ToString() => Name;
}
