using NUnit.Framework;
using MinefieldGame.Enums;

namespace MinefieldGame.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void PlayerLosesLifeWhenHitMine()
        {
            Player player = new Player();
            player.HitMine();
            Assert.That(player.Lives, Is.EqualTo(2));
        }

        [Test]
        public void PlayerCanMoveUp()
        {
            Player player = new Player { Position = (0, 0) };
            player.Move(Direction.Up);
            Assert.That(player.Position, Is.EqualTo((0, 1)));
        }

        [Test]
        public void PlayerCanMoveDown()
        {
            Player player = new() { Position = (0, 1) };
            player.Move(Direction.Down);
            Assert.That(player.Position, Is.EqualTo((0, 0)));
        }

        [Test]
        public void PlayerCanMoveLeft()
        {
            Player player = new Player { Position = (1, 0) };
            player.Move(Direction.Left);
            Assert.That(player.Position, Is.EqualTo((0, 0)));
        }

        [Test]
        public void PlayerCanMoveRight()
        {
            Player player = new Player { Position = (0, 0) };
            player.Move(Direction.Right);
            Assert.That(player.Position, Is.EqualTo((1, 0)));
        }

        [Test]
        public void PlayerCannotMoveOutOfBounds()
        {
            Player player = new Player { Position = (9, 0) };
            player.Move(Direction.Right);
            Assert.That(player.Position, Is.EqualTo((9, 0)));
        }
    }
}
