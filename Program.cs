using RockPaperScissors;

/// <summary>
/// Rock-Paper-Scissors Console Game
/// A simple game demonstrating C# OOP concepts:
/// - Abstract Classes (Move, Player)
/// - Inheritance (Rock/Paper/Scissors from Move, HumanPlayer/ComputerPlayer from Player)
/// - Polymorphism (Different GetMove() implementations for each player type)
/// - Encapsulation (Private fields, public properties)
/// </summary>

Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║  Welcome to Rock-Paper-Scissors!      ║");
Console.WriteLine("╚═══════════════════════════════════════╝");

Console.Write("\nEnter your name: ");
string? playerName = Console.ReadLine();

if (string.IsNullOrWhiteSpace(playerName))
{
    playerName = "Player";
}

// Create players - demonstrates polymorphism through Player base class
Player human = new HumanPlayer(playerName);
Player computer = new ComputerPlayer("Computer");

// Create and start the game
Game game = new Game(human, computer);
game.Start();
