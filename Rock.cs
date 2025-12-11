namespace RockPaperScissors;

/// <summary>
/// Concrete implementation of the Rock move.
/// Demonstrates inheritance from the abstract Move class.
/// </summary>
public class Rock : Move
{
    public Rock() : base("Rock")
    {
    }

    /// <summary>
    /// Rock beats Scissors but loses to Paper.
    /// </summary>
    public override bool Beats(Move other)
    {
        return other is Scissors;
    }
}
