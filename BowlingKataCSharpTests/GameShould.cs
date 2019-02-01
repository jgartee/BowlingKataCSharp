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

        [Fact(Skip = "Ignore while refactoring")]
        public void ScoreTenPlusNextFrameFirstRollOnSpare()
        {
            _game.Roll(5);
            _game.Roll(5);
            _game.Roll(2);
            _game.Roll(0);
            RollMany(16, 0);

            Assert.Equal(14, _game.Score());
        }

        [Fact]
        public void ScoreTwentyWhenEachRollKnocksDownOnePin()
        {
            RollMany(20, 1);

            Assert.Equal(20, _game.Score());
        }

        [Fact]
        public void ScoreZeroWhenAllGutterBallsThrown()
        {
            RollMany(20, 0);

            Assert.Equal(0, _game.Score());
        }
    }
}