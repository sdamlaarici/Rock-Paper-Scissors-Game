namespace RockPaperScissors;

/// <summary>
/// Concrete implementation of the Scissors move.
/// Demonstrates inheritance from the abstract Move class.
/// </summary>
public class Scissors : Move
{
    public Scissors() : base("Scissors")
    {
    }

    /// <summary>
    /// Scissors beats Paper but loses to Rock.
    /// </summary>
    public override bool Beats(Move other)
    {
        return other is Paper;
    }
}
