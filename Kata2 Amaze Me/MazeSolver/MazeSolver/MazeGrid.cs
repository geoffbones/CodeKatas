namespace MazeSolver
{
    public class MazeGrid
    {
        // +--------> +ve X
        // |
        // |
        // |
        // |
        // v
        // +ve Y
        private readonly bool[][] m_Grid; //bool[y][x]
        private readonly Point m_Start;
        private readonly Point m_Finish;

        public MazeGrid(bool[][] grid, Point start, Point finish)
        {
            m_Grid = grid;
            m_Start = start;
            m_Finish = finish;
        }

        public Point StartPosition
        {
            get { return m_Start; }
        }

        public bool AtFinish(DumbMazeWalker walker)
        {
            return Finish.X == walker.CurrentPosition.X && Finish.Y == walker.CurrentPosition.Y;
        }

        public Point Finish
        {
            get { return m_Finish; }
        }

        public bool[][] Grid
        {
            get { return m_Grid; }
        }
    }
}