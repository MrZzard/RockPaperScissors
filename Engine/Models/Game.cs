namespace RockPaperScissors.Models
{
    public class Game
    {
        public int BestOf { get; }

        public int Wins { get; private set; }

        public int Draws { get; private set; }

        public int Losses { get; private set; }

        public Game(int bestOf)
        {
            this.BestOf = bestOf;
            this.Wins = 0;
            this.Draws = 0;
            this.Losses = 0;
        }

        public void MatchWin() => this.Wins++;

        public void MatchLost() => this.Losses++;

        public void MatchDrawn() => this.Draws++;

        public bool IsPlayerWon() => this.Wins > this.Losses && this.IsGameOver();

        public bool IsGameOver() => this.Wins + this.Losses + this.Draws == this.BestOf;

        public string Score() => $"Score: {this.Wins} wins, {this.Losses} losses, {this.Draws} draws";
    }
}