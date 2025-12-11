namespace RockPaperScissors;

/// <summary>
/// Concrete implementation of a human player.
/// Demonstrates inheritance and polymorphism by providing human-specific move selection.
/// </summary>
public class HumanPlayer : Player
{
    public HumanPlayer(string name) : base(name)
    {
    }

    /// <summary>
    /// Gets a move from the human player via console input.
    /// Includes validation to ensure valid input.
    /// </summary>
    public override Move GetMove()
    {
        while (true)
        {
            Console.WriteLine($"\n{Name}, choose your move:");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            Console.Write("Enter your choice (1-3): ");

            string? input = Console.ReadLine();

            // Validate input
            Move? move = ValidateMove(input);
            if (move != null)
            {
                return move;
            }

            Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
        }
    }

    /// <summary>
    /// Validates and converts user input to a Move object.
    /// </summary>
    private Move? ValidateMove(string? input)
    {
        return input switch
        {
            "1" => new Rock(),
            "2" => new Paper(),
            "3" => new Scissors(),
            _ => null
        };
    }
}
