using Guess_the_number;

internal class Generator : IGenerator
{
    int IGenerator.GetValue(IConfig config)
    {
        return new Random().Next(config.MinValue, config.MaxValue);
    }
}