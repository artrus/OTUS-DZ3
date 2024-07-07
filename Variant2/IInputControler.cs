using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant2
{
    interface IInputControler
    {
        public GameCommand GetCommandInMainMenu();
        public int GetValue(int min, int max);
        public GameOptions GetOptions();
    }
}
