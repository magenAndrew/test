using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number
{
    public class Config : IConfig
    {
  
        int IConfig.AttempCount => 10;

        int IConfig.MaxValue => 10;

        int IConfig.MinValue => 10;
    }
}
