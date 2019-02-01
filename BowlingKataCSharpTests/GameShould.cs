using System;
using BowlingKataCSharp;
using Xunit;

namespace BowlingKataCSharpTests
{
    public class GameShould
    {
        [Fact]
        public void ScoreZeroWhenAllGutterBallsThrown()
        {
            var game = new Game();

            for (int i = 0; i < 20; i++)
                game.Roll(0);

            Assert.Equal(0, game.Score());
        }
    }
}
