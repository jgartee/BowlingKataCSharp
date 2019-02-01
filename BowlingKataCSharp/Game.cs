using System.Collections.Generic;
using System.Linq;

namespace BowlingKataCSharp
{
    public class Game
    {
        private readonly List<int> _rolls = new List<int>();
        private int _score;

        public void Roll(int pins)
        {
            _rolls.Add(pins);
        }

        public int Score()
        {
            var roll = 0;

            for (var frame = 0; frame < 10; frame++)
            {
                if (_rolls[roll] == 10)
                {
                    _score += 10 + _rolls[roll + 1] + _rolls[roll + 2];
                    roll += 1;
                }
                else
                {
                    if (IsASpare(roll))
                        _score += SpareFrameScoring(roll);
                    else
                        _score += OpenFrameScoring(roll);

                    roll += 2;
                }
            }

            return _score;
        }

        private int OpenFrameScoring(int roll)
        {
            return _rolls[roll] + _rolls[roll + 1];
        }

        private int SpareFrameScoring(int roll)
        {
            return 10 + _rolls[roll + 2];
        }

        private bool IsASpare(int roll)
        {
            return _rolls[roll] + _rolls[roll + 1] == 10;
        }
    }
}
