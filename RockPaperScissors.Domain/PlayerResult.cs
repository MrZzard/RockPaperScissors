namespace RockPaperScissors.Domain
{
    public class PlayerResult
    {
        public string PlayerName { get; }

        public string MoveName { get; }

        public PlayerResult(string playerName, string moveName)
        {
            this.PlayerName = playerName;
            this.MoveName = moveName;
        }
    }
}