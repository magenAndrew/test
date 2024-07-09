using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number
{
    internal class GameInteraction : IGameInteraction
    {
        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        public void Render(string value)
        {
            Console.WriteLine(value);
        }
    }
}
