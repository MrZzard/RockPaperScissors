using System;
using System.Collections.Generic;
using System.Linq;

using RockPaperScissors.Domain;
using RockPaperScissors.Domain.Moves;

namespace RockPaperScissors
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors");

            //Console.WriteLine("Select your opponent: [p]layer or [c]omputer");
            Game game = new Game(3);
            while (!game.IsGameOver())
            {
            }

            Console.ReadLine();
        }

        private IMove GetPlayerMove(IReadOnlyCollection<IMove> availableMoves)
        {
            IMove move = null;

            while (move == null)
            {
                Console.WriteLine($"Select your Move: {string.Join(", ", availableMoves)}");
                var value = Console.ReadLine();

                move = availableMoves.SingleOrDefault(x => x.IsMove(value));

                if (move == null)
                {
                    Console.WriteLine($"{value} is not a valid move.");
                }
            }

            return move;
        }
    }
}