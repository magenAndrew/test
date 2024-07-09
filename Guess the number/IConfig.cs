namespace Guess_the_number
{
    public interface IConfig
    {
        int MinValue { get; }
        int MaxValue { get; }
        int AttempCount{ get; }
    }
}