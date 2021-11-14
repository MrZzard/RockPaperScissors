using System;
using System.Collections.Generic;
using System.Linq;

using RockPaperScissors.Domain.Moves;
using RockPaperScissors.Domain.Players;

namespace RockPaperScissors
{
    public class ConsolePlayer : Player
    {
        public ConsolePlayer(string name)
            : base(name)
        {
        }

        public override IMove PlayMove(IReadOnlyCollection<IMove> availableMoves)
        {
            IMove move = null;

            while (move == null)
            {
                Console.WriteLine($"\n{this.Name} - Select your Move: {string.Join(", ", availableMoves.Select(x => x.NameSelection()))}");
                var value = Console.ReadLine();

                move = availableMoves.SingleOrDefault(x => x.IsMove(value));

                if (move == null)
                {
                    Console.WriteLine($"'{value}' is not a valid move.");
                }
            }

            return move;
        }
    }
}