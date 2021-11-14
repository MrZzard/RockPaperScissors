namespace RockPaperScissors.Domain.Moves
{
    public class Flamethrower : IMove
    {
        public string Name()
        {
            return "Flamethrower";
        }

        public string NameSelection()
        {
            return "[F]lamethrower";
        }

        public bool IsMove(string move)
        {
            move = move.ToLower();
            return move == "f" || move == "flamethrower" || move == "[f]lamethrower";
        }

        public bool WinAgainst(IMove move)
        {
            return move is Paper;
        }
    }
}