namespace RockPaperScissors;

/// <summary>
/// Concrete implementation of the Paper move.
/// Demonstrates inheritance from the abstract Move class.
/// </summary>
public class Paper : Move
{
    public Paper() : base("Paper")
    {
    }

    /// <summary>
    /// Paper beats Rock but loses to Scissors.
    /// </summary>
    public override bool Beats(Move other)
    {
        return other is Rock;
    }
}
