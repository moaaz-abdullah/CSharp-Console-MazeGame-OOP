using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGame
{
    public class Player
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Player(int x, int y) { X = x; Y = y; }

        public void MoveUp() { Y--; }

        public void MoveDown() { Y++; }

        public void MoveLeft() { X--; }

        public void MoveRight() { X++; }

    }
}
