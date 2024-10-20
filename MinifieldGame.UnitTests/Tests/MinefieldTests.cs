using NUnit.Framework;
using MinefieldGame;

namespace MinefieldGame.Tests
{
    [TestFixture]
    public class MinefieldTests
    {
        [Test]
        public void MinefieldCorrectNumberOfMines()
        {
            int gridSize = 10;
            int mineCount = 10;
            Minefield minefield = new Minefield(gridSize, mineCount);
            int placedMines = 0;

            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    if (minefield.CheckForMine(x, y))
                    {
                        placedMines++;
                    }
                }
            }

            Assert.That(placedMines, Is.EqualTo(mineCount));
        }
    }
}
