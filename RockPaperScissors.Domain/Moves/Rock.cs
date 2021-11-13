using System;
using System.Collections.Generic;

namespace RockPaperScissors.Domain.Moves
{
    public class Rock : IMove
    {
        public string Name => "Rock";

        public string Key => "r";

        public IEnumerable<IMove> WinAgainst()
        {
            throw new NotImplementedException();
        }

        
    }
}