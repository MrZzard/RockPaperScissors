namespace RockPaperScissors.Domain.Moves
{
    public class Paper : IMove

    {
        public string Name()
        {
            return "Paper";
        }

        public string NameSelection()
        {
            return "[P]aper";
        }

        public bool IsMove(string move)
        {
            move = move.ToLower();
            return move == "p" || move == "paper" || move == "[p]aper";
        }

        public bool WinAgainst(IMove move)
        {
            return move is Rock;
        }
    }
}