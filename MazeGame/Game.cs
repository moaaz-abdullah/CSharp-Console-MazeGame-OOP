using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MazeGame
{
    public class Game
    {
        private Player _myPlayer = new Player(1, 1);

        private Maze _myMaze;

        private bool _isGameOver;

        // Add timer, score system
        Stopwatch stopwatch = new Stopwatch();

        public Game()
        {
            string[] map = {
            "██████████████████████████████████████████████",
            "█          █                █          █  █  E",
            "█  █████████  ████████████  █  ██████  █  █  █",
            "█       █           █       █    █     █  █  █",
            "██████  █  ███████  █  ████████  █  ████  █  █",
            "█       █        █  █            █  █     █  █",
            "█  ████████████  █  ██████████████  █  █  █  █",
            "█  █          █  █       █          █  █  █  █",
            "█  █  ██████  █  █████████  ██████  █  █  █  █",
            "█  █       █  █          █       █  █  █  █  █",
            "█  ██████  █  █████  ██████████  ████  █  █  █",
            "█          █                  █        █     █",
            "██████████████████████████████████████████████"
            };
            _myMaze = new Maze(map);
        }

        public void Start()
        {
            while (_isGameOver == false)
            {
                Console.Clear();

                _myMaze.Draw();

                Console.SetCursorPosition(_myPlayer.X, _myPlayer.Y);

                // Symbol for our Player
                Console.WriteLine('●');

                if (_myMaze.IsExit(_myPlayer.X, _myPlayer.Y))
                {
                    Console.Clear();
                    stopwatch.Stop();
                    Winner();
                }
                else
                    HandleInput();
            }
        }

        private void HandleInput()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            stopwatch.Start();

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (!_myMaze.IsWall(_myPlayer.X, _myPlayer.Y - 1))
                        _myPlayer.MoveUp();
                    break;

                case ConsoleKey.DownArrow:
                    if (!_myMaze.IsWall(_myPlayer.X, _myPlayer.Y + 1))
                        _myPlayer.MoveDown();
                    break;

                case ConsoleKey.RightArrow:
                    if (!_myMaze.IsWall(_myPlayer.X + 1, _myPlayer.Y))
                        _myPlayer.MoveRight();
                    break;

                case ConsoleKey.LeftArrow:
                    if (!_myMaze.IsWall(_myPlayer.X - 1, _myPlayer.Y))
                        _myPlayer.MoveLeft();
                    break;

                default:
                    Console.WriteLine("Invalid key");
                    break;
            }
        }

        private void Winner()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("────────────────────────────────────────");
            Console.WriteLine("                𓆩༺✧༻𓆪                 ");
            Console.WriteLine(" ꧁   Winner Winner chicken dinner ꧂ ");
            Console.WriteLine("                                        ");
            Console.WriteLine("────────────────────────────────────────");
            Console.ResetColor();
            Console.WriteLine($"Elapsed Time: {(stopwatch.ElapsedMilliseconds) / 1000.0} sec");

            _isGameOver = true;
        }
    }
}
