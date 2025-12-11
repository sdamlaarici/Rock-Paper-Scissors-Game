namespace RockPaperScissors;

/// <summary>
/// Represents a single round of the game for history tracking.
/// </summary>
public class GameRound
{
    public int RoundNumber { get; }
    public string Player1Move { get; }
    public string Player2Move { get; }
    public string Result { get; }

    public GameRound(int roundNumber, string player1Move, string player2Move, string result)
    {
        RoundNumber = roundNumber;
        Player1Move = player1Move;
        Player2Move = player2Move;
        Result = result;
    }

    public override string ToString()
    {
        return $"Round {RoundNumber}: {Player1Move} vs {Player2Move} - {Result}";
    }
}
