# Rock-Paper-Scissors Game

A simple console game developed to practice C# and Object-Oriented Programming concepts.

## Description

This application simulates a Rock-Paper-Scissors game between a human player and the computer. It features a scoring system, move validation, and a summary of the game history upon exit.

## Features

- **Interactive Console Gameplay**: Play against the computer in multiple rounds
- **Scoring System**: Tracks wins for both players across all rounds
- **Move Validation**: Ensures valid input from the human player
- **Game History**: Displays a complete summary of all rounds played
- **Object-Oriented Design**: Demonstrates key OOP principles

## OOP Concepts Demonstrated

### Abstract Classes
- `Move`: Abstract base class for all game moves (Rock, Paper, Scissors)
- `Player`: Abstract base class for all player types

### Inheritance
- `Rock`, `Paper`, `Scissors`: Concrete classes inheriting from `Move`
- `HumanPlayer`, `ComputerPlayer`: Concrete classes inheriting from `Player`

### Polymorphism
- Different implementations of `GetMove()` method in `HumanPlayer` and `ComputerPlayer`
- Different implementations of `Beats()` method in each move type
- Both player types can be treated as `Player` objects

### Encapsulation
- Private fields with public properties
- Internal game logic encapsulated in appropriate classes

## Project Structure

```
Rock-Paper-Scissors-Game/
├── Program.cs           # Main entry point
├── Game.cs             # Game controller and logic
├── Move.cs             # Abstract base class for moves
├── Rock.cs             # Rock move implementation
├── Paper.cs            # Paper move implementation
├── Scissors.cs         # Scissors move implementation
├── Player.cs           # Abstract base class for players
├── HumanPlayer.cs      # Human player implementation
├── ComputerPlayer.cs   # Computer player implementation
└── GameRound.cs        # Game round data structure for history
```

## How to Run

### Prerequisites
- .NET 10.0 SDK or later

### Building the Project
```bash
dotnet build
```

### Running the Game
```bash
dotnet run
```

## How to Play

1. Enter your name when prompted
2. Choose your move by entering 1, 2, or 3:
   - 1: Rock
   - 2: Paper
   - 3: Scissors
3. The computer will randomly select its move
4. The winner of the round is determined:
   - Rock beats Scissors
   - Scissors beats Paper
   - Paper beats Rock
5. Scores are updated and displayed
6. Choose whether to play another round
7. When finished, view the game summary and complete history

## Game Rules

- Rock beats Scissors
- Scissors beats Paper
- Paper beats Rock
- Same moves result in a tie (no points awarded)

## Example Output

```
╔═══════════════════════════════════════╗
║  Welcome to Rock-Paper-Scissors!      ║
╚═══════════════════════════════════════╝

Enter your name: Alice
═══════════════════════════════════════
  Rock-Paper-Scissors Game Started!  
═══════════════════════════════════════

Alice vs Computer

=                                       
  Round 1
=                                       

Alice, choose your move:
1. Rock
2. Paper
3. Scissors
Enter your choice (1-3): 2

Computer chose: Rock

Alice chose: Paper
Computer chose: Rock

>>> Alice wins this round! <<<

--- Current Scores ---
Alice: 1
Computer: 0

Do you want to play another round? (y/n): n

╔═══════════════════════════════════════╗
║         GAME SUMMARY & HISTORY        ║
╚═══════════════════════════════════════╝

Total Rounds Played: 1

--- Final Scores ---
Alice: 1
Computer: 0

--- Overall Winner ---
🏆 Alice wins the game!

--- Round History ---
Round 1: Paper vs Rock - Alice wins this round!

═══════════════════════════════════════
  Thank you for playing!  
═══════════════════════════════════════
```

## Technologies Used

- **C# Programming Language**
- **.NET 10.0**
- **Console Application**

## Learning Objectives

This project demonstrates:
- Abstract classes and their usage
- Inheritance hierarchies
- Polymorphic behavior
- Encapsulation principles
- Clean code organization
- Input validation
- State management 
