namespace RockPaperScissors.Domain.Moves
{
    public class Rock : IMove
    {
        public string Name()
        {
            return "Rock";
        }

        public string NameSelection()
        {
            return "[R]ock";
        }

        public bool IsMove(string move)
        {
            move = move.ToLower();
            return move == "r" || move == "rock" || move == "[r]ock";
        }

        public bool WinAgainst(IMove move)
        {
            return move is Scissors || move is Flamethrower;
        }
    }
}