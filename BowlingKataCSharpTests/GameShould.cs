using BowlingKataCSharp;
using Xunit;

namespace BowlingKataCSharpTests
{
    public class GameShould
    {
        public GameShould()
        {
            _game = new Game();
        }

        private readonly Game _game;

        private void RollMany(int rolls, int pins)
        {
            for (var i = 0; i < rolls; i++)
                _game.Roll(pins);
        }

        [Fact]
        public void ScoreZeroWhenAllGutterBallsThrown()
        {
            RollMany(20, 0);

            Assert.Equal(0, _game.Score());
        }
    }
}