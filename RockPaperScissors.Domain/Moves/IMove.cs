namespace RockPaperScissors.Domain.Moves
{
    public interface IMove

    {
        string Name();

        string NameSelection();

        bool IsMove(string move);

        bool WinAgainst(IMove move);
    }
}