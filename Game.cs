using System;
using System.Collections.Generic;

namespace RockPaperScissorsGame
{
    public enum Move
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3
    }
    public abstract class Participant
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Move SelectedMove { get; set; }

        public Participant(string name)
        {
            Name = name;
            Score = 0;
        }
        public abstract void MakeMove();
    }
    public abstract class Player : Participant
    {
                protected Player(string name) : base(name) { }
    }

    public abstract class ComputerPlayer : Participant
    {
        protected ComputerPlayer(string name) : base(name) { }
    }

    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name) { }

        public override void MakeMove()
        {
            while (true)
            {
                Console.Write($"\n{Name}, Choose Your Move (1-Rock, 2-Paper, 3-Scissors): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 3)
                {
                    SelectedMove = (Move)choice;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter 1, 2, or 3.");
                }
            }
        }
    }

    public class RandomComputerPlayer : ComputerPlayer
    {
        private Random random;

        public RandomComputerPlayer(string name) : base(name)
        {
            random = new Random();
        }

        public override void MakeMove()
        {
            int randomChoice = random.Next(1, 4);
            SelectedMove = (Move)randomChoice;
        }
    }
    public class GameEngine
    {
        private Player _player;
        private ComputerPlayer _computer;
        private List<string> moveHistory;

        public GameEngine()
        {
            moveHistory = new List<string>();
        }

        public void Start()
        {
            Console.WriteLine("=== WELCOME TO ROCK-PAPER-SCISSORS GAME ===");

            Console.Write("Please enter your name: ");
            string playerName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(playerName)) playerName = "Player";

            _player = new HumanPlayer(playerName);
            _computer = new RandomComputerPlayer("Computer");
            bool continuePlaying = true;
            int roundNumber = 1;

            while (continuePlaying)
            {
                Console.WriteLine($"\n--- {roundNumber}. ROUND ---");
                
                _player.MakeMove();      
                _computer.MakeMove();   

                Console.WriteLine($"{_player.Name} chose: {_player.SelectedMove}");
                Console.WriteLine($"{_computer.Name} chose: {_computer.SelectedMove}");
                DetermineWinner(roundNumber);


                Console.WriteLine($"\nCurrent Scores -> {_player.Name}: {_player.Score} | {_computer.Name}: {_computer.Score}");

                Console.Write("\nDo you want to play again? (Y/N): ");
                string answer = Console.ReadLine().Trim().ToUpper();
                if (answer != "Y")
                {
                    continuePlaying = false;
                }
                else
                {
                    roundNumber++;
                }
            }

            EndGame();
        }

        private void DetermineWinner(int round)
        {
            string resultMessage = "";

            if (_player.SelectedMove == _computer.SelectedMove)
            {
                resultMessage = "DRAW!";
            }
            else if (
                (_player.SelectedMove == Move.Rock && _computer.SelectedMove == Move.Scissors) ||
                (_player.SelectedMove == Move.Paper && _computer.SelectedMove == Move.Rock) ||
                (_player.SelectedMove == Move.Scissors && _computer.SelectedMove == Move.Paper)
            )
            {
                resultMessage = $"{_player.Name.ToUpper()} WINS!";
                _player.Score++;
            }
            else
            {
                resultMessage = $"{_computer.Name.ToUpper()} WINS!";
                _computer.Score++;
            }

            Console.WriteLine($"RESULT: {resultMessage}");

            string record = $"Round {round}: {_player.Name}({_player.SelectedMove}) vs {_computer.Name}({_computer.SelectedMove}) -> {resultMessage}";
            _moveHistory.Add(record);
        }

        private void EndGame()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("GAME OVER");
            
            Console.WriteLine($"TOTAL SCORE: {_player.Name} {_player.Score} - {_computer.Score} {_computer.Name}");

            Console.WriteLine("\n--- GAME HISTORY ---");
            foreach (var record in _moveHistory)
            {
                Console.WriteLine(record);
            }
            Console.WriteLine("----------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GameEngine game = new GameEngine();
            game.Start();
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
