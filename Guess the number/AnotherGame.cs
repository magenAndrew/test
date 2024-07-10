using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number
{
    public class AnotherGame : Game
    {

        public override void ProcessGame()
        {
            int attemptCount = 0;
            int tmpValue = config.MinValue - 1;
            int value = generator.GetValue(config);
            string userInput;

            gameInteraction.Render($"Игра началась.");

            while (!(value == tmpValue || attemptCount == config.AttempCount))
            {
                gameInteraction.Render($"Попытка {++attemptCount}.");
                gameInteraction.Render($"Ваш ход.");
                userInput = gameInteraction.GetUserInput();
                string step = (!int.TryParse(userInput, out tmpValue)) ? "Бред!" : (tmpValue < value) ? $"Мало!" : $"Много!";
                gameInteraction.Render(step);
            }
            var result = (value == tmpValue) ? "Ты знал!" : $"Тебе повезет! Искомое число:{value}";
            gameInteraction.Render(result);
        }
        public AnotherGame(IConfig config, IGenerator generator, IGameInteraction gameInteraction) : base(config, generator, gameInteraction)
        {
            Console.WriteLine("Простая игра");
        }
    }
}
