using System.Collections.Generic;

using RockPaperScissors.Domain.Moves;

namespace RockPaperScissors.Domain.Players
{
    public abstract class Player : IPlayer
    {
        public string Name { get; }

        protected Player(string name)
        {
            this.Name = name;
        }

        public abstract IMove PlayMove(IReadOnlyCollection<IMove> availableMoves);
    }
}