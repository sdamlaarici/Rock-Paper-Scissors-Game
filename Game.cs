namespace RockPaperScissors;

/// <summary>
/// Main game controller class that manages the Rock-Paper-Scissors game.
/// Handles scoring, game history, and round logic.
/// </summary>
public class Game
{
    private readonly Player _player1;
    private readonly Player _player2;
    private readonly List<GameRound> _gameHistory;
    private int _roundNumber;

    public Game(Player player1, Player player2)
    {
        _player1 = player1;
        _player2 = player2;
        _gameHistory = new List<GameRound>();
        _roundNumber = 0;
    }

    /// <summary>
    /// Starts and runs the main game loop.
    /// </summary>
    public void Start()
    {
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("  Rock-Paper-Scissors Game Started!  ");
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine($"\n{_player1.Name} vs {_player2.Name}");

        bool playing = true;

        while (playing)
        {
            PlayRound();
            DisplayScores();
            
            Console.WriteLine("\nDo you want to play another round? (y/n): ");
            string? response = Console.ReadLine()?.ToLower();
            
            if (response != "y" && response != "yes")
            {
                playing = false;
            }
        }

        DisplayGameSummary();
    }

    /// <summary>
    /// Plays a single round of Rock-Paper-Scissors.
    /// </summary>
    private void PlayRound()
    {
        _roundNumber++;
        Console.WriteLine($"\n{'=',-40}");
        Console.WriteLine($"  Round {_roundNumber}");
        Console.WriteLine($"{'=',-40}");

        // Polymorphism in action: both players use GetMove() but with different implementations
        Move player1Move = _player1.GetMove();
        Move player2Move = _player2.GetMove();

        Console.WriteLine($"\n{_player1.Name} chose: {player1Move}");
        Console.WriteLine($"{_player2.Name} chose: {player2Move}");

        // Determine winner using abstract method implementation
        string result = DetermineWinner(player1Move, player2Move);
        Console.WriteLine($"\n>>> {result} <<<");

        // Record round in history
        _gameHistory.Add(new GameRound(_roundNumber, player1Move.ToString(), 
            player2Move.ToString(), result));
    }

    /// <summary>
    /// Determines the winner of a round and updates scores.
    /// </summary>
    private string DetermineWinner(Move player1Move, Move player2Move)
    {
        if (player1Move.GetType() == player2Move.GetType())
        {
            return "It's a tie!";
        }
        else if (player1Move.Beats(player2Move))
        {
            _player1.Score++;
            return $"{_player1.Name} wins this round!";
        }
        else
        {
            _player2.Score++;
            return $"{_player2.Name} wins this round!";
        }
    }

    /// <summary>
    /// Displays the current scores.
    /// </summary>
    private void DisplayScores()
    {
        Console.WriteLine("\n--- Current Scores ---");
        Console.WriteLine($"{_player1.Name}: {_player1.Score}");
        Console.WriteLine($"{_player2.Name}: {_player2.Score}");
    }

    /// <summary>
    /// Displays the complete game summary and history upon exit.
    /// </summary>
    private void DisplayGameSummary()
    {
        Console.WriteLine("\n╔═══════════════════════════════════════╗");
        Console.WriteLine("║         GAME SUMMARY & HISTORY        ║");
        Console.WriteLine("╚═══════════════════════════════════════╝");

        Console.WriteLine($"\nTotal Rounds Played: {_roundNumber}");
        Console.WriteLine("\n--- Final Scores ---");
        Console.WriteLine($"{_player1.Name}: {_player1.Score}");
        Console.WriteLine($"{_player2.Name}: {_player2.Score}");

        // Determine overall winner
        Console.WriteLine("\n--- Overall Winner ---");
        if (_player1.Score > _player2.Score)
        {
            Console.WriteLine($"🏆 {_player1.Name} wins the game!");
        }
        else if (_player2.Score > _player1.Score)
        {
            Console.WriteLine($"🏆 {_player2.Name} wins the game!");
        }
        else
        {
            Console.WriteLine("🤝 The game is a tie!");
        }

        // Display round-by-round history
        if (_gameHistory.Count > 0)
        {
            Console.WriteLine("\n--- Round History ---");
            foreach (var round in _gameHistory)
            {
                Console.WriteLine(round);
            }
        }

        Console.WriteLine("\n═══════════════════════════════════════");
        Console.WriteLine("  Thank you for playing!  ");
        Console.WriteLine("═══════════════════════════════════════");
    }
}
