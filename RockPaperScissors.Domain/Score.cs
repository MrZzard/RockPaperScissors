using System;

namespace RockPaperScissors.Domain
{
    public class Score
    {
        public int Wins { get; private set; }

        public int Draws { get; private set; }

        public int Losses { get; private set; }

        private Score(int wins, int draws, int losses)
        {
            if (wins < 0 || draws < 0 || losses < 0)
            {
                throw new ArgumentOutOfRangeException("Score can't be negative");
            }

            this.Wins = wins;
            this.Draws = draws;
            this.Losses = losses;
        }

        public static Score New() => new Score(0, 0, 0);

        public Score MatchWon() => new Score(this.Wins++, this.Losses, this.Draws);

        public Score MatchLost() => new Score(this.Wins, this.Losses++, this.Draws);

        public Score MatchDrawn() => new Score(this.Wins, this.Losses, this.Draws++);
    }
}