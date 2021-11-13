using System.Collections.Generic;

namespace RockPaperScissors.Domain.Moves
{
    public interface IMove
    {
        public bool IsMove(string move);

        IEnumerable<IMove> WinAgainst();
    }
}