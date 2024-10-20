using MinefieldGame.Enums;

namespace MinefieldGame
{
    public class Player
    {
        public int Lives { get; set; } = 3;
        public int Moves { get; set; } = 0;
        public (int x, int y) Position { get; set; } = (0, 0);
        public bool HasWon => Position.y == 9;

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    if (Position.y < 9)
                    {
                        Position = (Position.x, Position.y + 1);
                        Moves++;
                    }
                    break;

                case Direction.Down:
                    if (Position.y > 0)
                    {
                        Position = (Position.x, Position.y - 1);
                        Moves++;
                    }
                    else
                    {
                        Console.WriteLine("You've reached the edge of the grid!");
                    }
                    break;

                case Direction.Left:
                    if (Position.x > 0)
                    {
                        Position = (Position.x - 1, Position.y);
                        Moves++;
                    }
                    else
                    {
                        Console.WriteLine("You've reached the edge of the grid!");
                    }
                    break;

                case Direction.Right:
                    if (Position.x < 9)
                    {
                        Position = (Position.x + 1, Position.y);
                        Moves++;
                    }
                    else
                    {
                        Console.WriteLine("You've reached the edge of the grid!");
                    }
                    break;
            }
        }


        public void HitMine()
        {
            Lives--;
        }
    }
}