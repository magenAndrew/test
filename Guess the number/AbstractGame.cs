using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number
{
    public abstract  class AbstractGame
    {
        protected IConfig config;
        protected IGenerator generator;
        protected IGameInteraction gameInteraction;
        protected int attempCount;

        public virtual void ProcessGame() {
            Console.WriteLine("Game over");
        }
        public AbstractGame(IConfig config, IGenerator generator, IGameInteraction gameInteraction)
        {
            this.config = config;
            this.generator = generator;
            this.gameInteraction = gameInteraction;
        }

    }
}
