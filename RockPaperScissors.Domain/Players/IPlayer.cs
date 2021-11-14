using System.Collections.Generic;

using RockPaperScissors.Domain.Moves;

namespace RockPaperScissors.Domain.Players
{
    public interface IPlayer
    {
        IMove PlayMove(IReadOnlyCollection<IMove> availableMoves);
    }
}