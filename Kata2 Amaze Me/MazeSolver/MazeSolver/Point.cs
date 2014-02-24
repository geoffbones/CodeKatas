using System;

namespace MazeSolver
{
    public class Point
    {
        public int X { set; get; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return String.Format("Point({0}, {1})", X, Y);
        }
    }
}