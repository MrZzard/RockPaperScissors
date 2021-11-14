using System;
using System.Collections.Generic;

using RockPaperScissors.Domain;
using RockPaperScissors.Domain.Moves;
using RockPaperScissors.Domain.Players;

namespace RockPaperScissors
{
    public class ConsoleGame : Game
    {
        public ConsoleGame(int bestOf, IReadOnlyCollection<IMove> availableMoves, Player player1, Player player2)
            : base(bestOf, availableMoves, player1, player2)
        {
        }

        protected override void ShowScore()
        {
            Console.WriteLine(
                $"\n Best of {this.BestOf} - {this.Player1.Name} won {this.Score.Wins} | {this.Player2.Name} won {this.Score.Losses} | Draws {this.Score.Draws}");
        }

        protected override void ShowMatchResult(MatchResult result)
        {
            Console.Clear();
            if (result != null)
            {
                Console.WriteLine($"\n{result.Winner.PlayerName} win the Match!");
                Console.WriteLine($"\n{result.Winner.PlayerName} {result.Winner.MoveName} beats {result.Loser.PlayerName} {result.Loser.MoveName}");
            }
            else
            {
                Console.WriteLine("\nThis is a draw!");
            }

            this.ShowScore();

            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadLine();
        }

        protected override void ShowGameWinner()
        {
            var winner = this.IsPlayerWon() ? this.Player1 : this.Player2;

            Console.Clear();
            Console.WriteLine($"\n\n{winner.Name} has won!");

            this.ShowScore();

            Console.WriteLine("\n\nPress any key to quit");
            Console.ReadLine();
        }
    }
}