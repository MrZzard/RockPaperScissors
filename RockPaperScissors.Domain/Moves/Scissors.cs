namespace RockPaperScissors.Domain.Moves
{
    public class Scissors : IMove

    {
        public string Name()
        {
            return "Scissors";
        }

        public string NameSelection()
        {
            return "[S]cissors";
        }

        public bool IsMove(string move)
        {
            move = move.ToLower();
            return move == "s" || move == "scissors" || move == "[s]cissors";
        }

        public bool WinAgainst(IMove move)
        {
            return move is Paper || move is Flamethrower;
        }
    }
}