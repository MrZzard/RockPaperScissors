namespace RockPaperScissors.Domain
{
    public class Game
    {
        public int BestOf { get; }

        public Score Score { get; }

        public Game(int bestOf)
        {
            this.BestOf = bestOf;
            this.Score = Score.New();
        }

        public bool IsPlayerWon() => this.IsGameOver() && this.Score.Wins > this.Score.Losses;

        public bool IsGameOver() => this.Score.NumberOfMatches() == this.BestOf;
    }
}