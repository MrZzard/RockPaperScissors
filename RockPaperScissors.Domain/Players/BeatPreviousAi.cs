using System.Collections.Generic;
using System.Linq;

using RockPaperScissors.Domain.Moves;

namespace RockPaperScissors.Domain.Players
{
    public class BeatPreviousAi : Player
    {
        private IMove _previousMove;

        public BeatPreviousAi()
            : base(nameof(BeatPreviousAi))
        {
        }

        public override IMove PlayMove(IReadOnlyCollection<IMove> availableMoves)
        {
            this._previousMove = this._previousMove == null ? availableMoves.First() : availableMoves.First(x => x.WinAgainst(this._previousMove));

            return this._previousMove;
        }
    }
}