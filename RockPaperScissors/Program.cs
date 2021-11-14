using System;
using System.Collections.Generic;

using RockPaperScissors.Domain.Moves;
using RockPaperScissors.Domain.Players;

namespace RockPaperScissors
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors");

            var moves = new List<IMove> { new Rock(), new Paper(), new Scissors(), new Flamethrower() };
            var opponent = GetOpponent();
            var bestOf = SelectGameLength();

            var game = new ConsoleGame(bestOf, moves, new ConsolePlayer("Player1"), opponent);

            game.PlayGame();
        }

        private static int SelectGameLength()
        {
            var bestOf = 0;

            while (bestOf % 2 == 0 || bestOf <= 0)
            {
                Console.WriteLine("\nPlease select an odd positive integer number of match to win.");
                var value = Console.ReadLine();
                try
                {
                    bestOf = int.Parse(value!);
                }
                catch
                {
                    Console.WriteLine($"\n{value} is not a integer number.");
                }
            }

            return bestOf;
        }

        private static Player GetOpponent()
        {
            Player opponent;

            Console.WriteLine("\nWould you like to play vs a [P]layer, a [R]andomAi or a [B]eatPreviousAi?");
            var value = Console.ReadLine();
            switch (value?.ToLower())
            {
                case "player":
                case "p":
                    opponent = new ConsolePlayer("Player2");
                    break;
                case "randomai":
                case "r":
                    opponent = new RandomAi();
                    break;
                case "beatpreviousai":
                case "b":
                    opponent = new BeatPreviousAi();
                    break;
                default:
                    Console.WriteLine($"\n'{value}' is not a valid option.");
                    opponent = GetOpponent();
                    break;
            }

            return opponent;
        }
    }
}