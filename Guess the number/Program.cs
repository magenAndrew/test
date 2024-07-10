using Guess_the_number;
using Microsoft.Extensions.DependencyInjection;
public class Program
{
   
    private static void Main(string[] args)
    {
        //В идеале зависимости должны предоставляться классу извне, а не создаваться внутри. 
        //Это обеспечивает лучшую гибкость, тестируемость и удобство сопровождения кода.
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IGenerator, Generator>()
 //           .AddSingleton<IConfig, Config>()
            .AddSingleton<IConfig, ConfigJson>()
            .AddSingleton<IGameInteraction, GameInteraction>()
            .BuildServiceProvider();

        new Game(
            serviceProvider.GetService<IConfig>(),
            serviceProvider.GetService<IGenerator>(),
            serviceProvider.GetService<IGameInteraction>()
            ).ProcessGame();
 
        new AnotherGame(
              serviceProvider.GetService<IConfig>(),
              serviceProvider.GetService<IGenerator>(),
              serviceProvider.GetService<IGameInteraction>()
              ).ProcessGame();
    }
}