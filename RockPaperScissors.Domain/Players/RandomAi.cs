using System;
using System.Collections.Generic;
using System.Linq;

using RockPaperScissors.Domain.Moves;

namespace RockPaperScissors.Domain.Players
{
    public class RandomAi : Player
    {
        private readonly Random _random;

        public RandomAi()
            : base(nameof(RandomAi))
        {
            this._random = new Random();
        }

        public override IMove PlayMove(IReadOnlyCollection<IMove> availableMoves)
        {
            var index = this._random.Next(availableMoves.Count());
            return availableMoves.ElementAt(index);
        }
    }
}