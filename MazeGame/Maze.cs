using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGame
{
    public class Maze
    {
        private string[] _grid;

        public int Width { get; set; }

        public int Height { get; set; }

        public Maze(string[] grid)
        {
            _grid = grid;
            Height = _grid.Length;
            Width = _grid[0].Length;
        }

        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                Console.WriteLine(_grid[i]);
            }
        }

        public bool IsWall(int x, int y)
        {
            if (x < 0 || x >= Width || y < 0 || y >= Height)
                return true;

            return _grid[y][x] == '█';
        }

        public bool IsExit(int x, int y)
        {
            if (x < 0 || x >= Width || y < 0 || y >= Height)
                return false;

            return _grid[y][x] == 'E';
        }
    }
}