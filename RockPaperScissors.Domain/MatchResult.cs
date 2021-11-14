namespace RockPaperScissors.Domain
{
    public class MatchResult
    {
        public PlayerResult Winner { get; }

        public PlayerResult Loser { get; }

        public MatchResult(PlayerResult winner, PlayerResult loser)
        {
            this.Winner = winner;
            this.Loser = loser;
        }
    }
}