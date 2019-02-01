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
            return _rolls.Sum();
        }
    }
}