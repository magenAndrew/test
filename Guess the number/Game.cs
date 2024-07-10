using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number
{/// <summary>
/// Класс, отвечающий за игру
/// </summary>
    public class Game :AbstractGame
    {
 
        /// <summary>
        /// Согласно принципу единой ответственности, у класса должна быть только одна причина для изменения.
        /// Собственно игра. Причина изменить этот класс - только изменение процесса игры  (S)  
        /// </summary>
        public override void ProcessGame()
        {
            int attemptCount = 0;
            int tmpValue = config.MinValue -1;
            int value = generator.GetValue(config);
            string userInput;

            gameInteraction.Render($"«Угадай число».");
            gameInteraction.Render($"Смысл игры заключается в том, что компьютер рандомно загадывает число от {config.MinValue} до {config.MaxValue}.");
            gameInteraction.Render($"а пользователь должен угадать это число, имея ограниченное число попыток: {config.AttempCount}.");
            gameInteraction.Render($"Игра началась.");

            while (!(value == tmpValue || attemptCount == config.AttempCount )) {
                gameInteraction.Render($"Попытка {++attemptCount}.");
                gameInteraction.Render($"Введите число и нажмите <Enter>.");
                userInput = gameInteraction.GetUserInput();
                string step = (!int.TryParse(userInput, out tmpValue))? "Это не целое число!":(tmpValue < value)?$"Маловато будет!": $"Перелет!";
                gameInteraction.Render(step);               
            }
            var result = (value == tmpValue) ? "Вы выиграли!" : $"Попытки закончились! Искомое число:{value}";
            gameInteraction.Render(result);
         }
        /// <summary>
        /// Конструктор. Поведение класса зависит только от интерфейсов
        /// Чтобы придерживаться ISP, надо разделить общий интерфейс на более мелкие и более специализированные интерфейсы, предназначенные для определенных типов  процессов (ISP)
        /// </summary>
        /// <param name="config"></param>
        /// <param name="generator"></param>
        /// <param name="gameInteraction"></param>
        public Game(IConfig config, IGenerator generator, IGameInteraction gameInteraction):base(config, generator, gameInteraction) {
            gameInteraction.Render($"Настраиваем игру");
        }

    }
}
