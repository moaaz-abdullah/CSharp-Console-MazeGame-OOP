# 🧩 Maze Game (C# Console - OOP Practice)

A simple **Console Maze Game** built using **C#** to practice and understand core **Object-Oriented Programming (OOP)** concepts.

The player navigates through a maze using arrow keys while avoiding walls and trying to reach the exit.

---

## 🎮 Features

- Console-based rendering
- Player movement using arrow keys
- Collision detection (walls blocking movement)
- Win condition (reach the exit)
- OOP structure (Game, Player, Maze classes)

---

## 🏗️ Project Structure

### `Program.cs`
Entry point of the application.

### `Game.cs`
Controls the game loop, input handling, and game state.

### `Maze.cs`
Responsible for:
- Storing the maze layout
- Drawing the maze
- Detecting walls and exit

### `Player.cs`
Represents the player position and movement logic.

---

## 🕹️ How to Play

Use the arrow keys:

- ⬆ Move Up  
- ⬇ Move Down  
- ⬅ Move Left  
- ➡ Move Right  

🎯 Objective: Reach the exit `E` without passing through walls.

---

## 🧠 What I Learned

- Object-Oriented Programming (OOP)
- Separation of responsibilities
- Basic game loop structure
- Collision detection logic
- Console rendering techniques

---

## 🚀 Future Improvements

- Add random maze generation
- Add levels system
- Add enemies or traps

---

## 📸 Screenshot

<img width="1366" height="720" alt="image" src="https://github.com/user-attachments/assets/bbba1e51-a6f5-4e8f-bdac-11ccf0ccfaab" />

---

## 🛠️ Tech Stack

- C#
- .NET Console Application

---

## 📌 Author\ Moaaz Abdullah

Built for learning purposes to improve OOP and game logic skills in C#.

---

## 📐 Class Diagram (UML)

```mermaid
classDiagram

class Program {
    +Main(string[] args)
}

class Game {
    -Player _myPlayer
    -Maze _myMaze
    -bool _isGameOver
    +Start()
    -HandleInput()
}

class Player {
    +int X
    +int Y
    +Player(int x, int y)
    +MoveUp()
    +MoveDown()
    +MoveLeft()
    +MoveRight()
}

class Maze {
    -string[] _grid
    +int Width
    +int Height
    +Maze(string[] grid)
    +Draw()
    +IsWall(int x, int y)
    +IsExit(int x, int y)
}

Program --> Game
Game --> Player
Game --> Maze
