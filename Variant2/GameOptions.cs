using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant2
{
    internal class GameOptions
    {
        public int MaxValue;
        public int CountAttempts;

        public GameOptions()
        {
            MaxValue = 100;
            CountAttempts = 10;
        }
    }
}
