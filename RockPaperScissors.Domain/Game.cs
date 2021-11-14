using System.Collections.Generic;

using RockPaperScissors.Domain.Moves;
using RockPaperScissors.Domain.Players;

namespace RockPaperScissors.Domain
{
    public abstract class Game
    {
        public int BestOf { get; }

        public IReadOnlyCollection<IMove> AvailableMoves { get; }

        public Score Score { get; }

        public Player Player1 { get; }

        public Player Player2 { get; }

        protected Game(int bestOf, IReadOnlyCollection<IMove> availableMoves, Player player1, Player player2)
        {
            this.BestOf = bestOf;
            this.AvailableMoves = availableMoves;
            this.Score = Score.New();
            this.Player1 = player1;
            this.Player2 = player2;
        }

        public void PlayGame()
        {
            while (!this.IsGameOver())
            {
                var result = this.PlayMatch();
                this.ShowMatchResult(result);
            }

            this.ShowGameWinner();
        }

        private MatchResult PlayMatch()
        {
            var player1Move = this.Player1.PlayMove(this.AvailableMoves);
            var player2Move = this.Player2.PlayMove(this.AvailableMoves);
            return this.JudgeMatch(player1Move, player2Move);
        }

        protected abstract void ShowScore();

        protected abstract void ShowMatchResult(MatchResult result);

        protected abstract void ShowGameWinner();

        protected bool IsPlayerWon() => this.IsGameOver() && this.Score.Wins > this.Score.Losses;

        protected bool IsGameOver() => this.Score.Wins + this.Score.Losses == this.BestOf;

        protected MatchResult JudgeMatch(IMove playerMove1, IMove playerMove2)
        {
            if (playerMove1.WinAgainst(playerMove2))
            {
                this.Score.MatchWon();
                return new MatchResult(
                    new PlayerResult(this.Player1.Name, playerMove1.Name()),
                    new PlayerResult(this.Player2.Name, playerMove2.Name()));
            }

            if (playerMove2.WinAgainst(playerMove1))
            {
                this.Score.MatchLost();
                return new MatchResult(
                    new PlayerResult(this.Player2.Name, playerMove2.Name()),
                    new PlayerResult(this.Player1.Name, playerMove1.Name()));
            }

            this.Score.MatchDrawn();
            return null;
        }
    }
}