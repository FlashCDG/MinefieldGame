namespace MinefieldGame
{
    public class Minefield
    {
        private readonly bool[,] grid;

        public Minefield(int gridSize, int mines)
        {
            grid = new bool[gridSize, gridSize];
            PlaceMines(mines);
        }

        private void PlaceMines(int mines)
        {
            Random rand = new Random();

            for (int i = 0; i < mines; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(mines);
                    y = rand.Next(mines);
                } while (grid [x, y]);

                grid [x, y] = true;
            }
        }

        public bool CheckForMine(int x, int y)
        {
            return grid [x, y];
        }
    }
}
