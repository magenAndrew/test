namespace Guess_the_number
{
    public interface IGameInteraction
    {
        void Render(string value);
        string GetUserInput();
    }
}