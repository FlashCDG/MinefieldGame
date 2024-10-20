using MinefieldGame.Enums;

namespace MinefieldGame
{
    public class Game
    {
        private readonly Minefield minefield;
        private readonly Player player;

        public Game()
        {
            minefield = new Minefield(10,10);
            player = new Player();
        }

        public void Play()
        {
            Console.WriteLine("Welcome to the Minefield Game!");
            while (player.Lives > 0 && !player.HasWon)
            {
                DisplayStatus();
                var direction = GetPlayerInput();
                player.Move(direction);

                if(minefield.CheckForMine(player.Position.x, player.Position.y))
                {
                    player.HitMine();
                    Console.WriteLine("You hit a mine!");
                }

                if (player.HasWon)
                {
                    Console.WriteLine("Congratulations, you won the game!");
                    Console.WriteLine($"Remaining Lives: {player.Lives}");
                    Console.WriteLine($"Final Score: {player.Moves}");
                }
            }

            if (player.Lives <= 0)
            {
                Console.WriteLine("Game Over! You've run out of lives.");
                Console.WriteLine($"Final Score: {player.Moves}");
            }
        }

        private static Direction GetPlayerInput()
        {
            while (true)
            {
                Console.WriteLine("Enter direction (WASD)");
                var keyInfo = Console.ReadKey(true);
                char input = char.ToUpper(keyInfo.KeyChar);

                switch (input)
                {
                    case 'W':
                        return Direction.Up;
                    case 'S':
                        return Direction.Down;
                    case 'A':
                        return Direction.Left;
                    case 'D':
                        return Direction.Right;
                    default:
                        Console.WriteLine("Invalid key pressed. Please try again.");
                        break;
                }
            }
        }

        private void DisplayStatus()
        {
            Console.WriteLine($"Position: {player.Position}");
            Console.WriteLine($"Lives: {player.Lives}");
            Console.WriteLine($"Moves: {player.Moves}");
            Console.WriteLine("");
        }
    }
}
