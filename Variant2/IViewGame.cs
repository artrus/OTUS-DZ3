using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant2
{
    internal interface IViewGame
    {
        public void SayHello();
        public void ViewMenu();
        public void ViewOptions();
        public void SayNewGame(int range, int attemps);
        public void SayGameOver();
        public void SayYouWinner();
        public void SayGreater();
        public void SayLess();

    }
}
