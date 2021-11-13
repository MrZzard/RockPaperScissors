using System.Collections.Generic;

namespace RockPaperScissors.Models
{
    public interface IMove
    {
        IEnumerable<IMove> WinAgainst();

        
    }
}