using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant2
{
    internal class ViewGameInConsole : IViewGame
    {
        public void SayHello()
        {
            Console.WriteLine("Hello! It's perfect game \nMain menu:");
        }
        public void SayNewGame(int range, int attemps)
        {
            Console.Clear();
            Console.WriteLine($"Game started. Range 0..{range}. Attemps {attemps}");
        }
        public void SayGameOver()
        {
            Console.WriteLine("Game Over");
            Console.ReadLine();
        }
        public void SayYouWinner()
        {
            Console.WriteLine("You Winner!!!");
            Console.ReadLine();
        }
        public void SayGreater()
        {
            Console.WriteLine("Input greater");
        }
        public void SayLess()
        {
            Console.WriteLine("Input less");
        }

        public void ViewMenu()
        {
            Console.Clear();
            Console.WriteLine("Hello! Try to play game");
            Console.WriteLine();
            Console.WriteLine("MAIN MENU:");
            Console.WriteLine("1 - New game");
            Console.WriteLine("2 - Set options");
            Console.WriteLine("3 - Exit");
            Console.WriteLine("Input command:");
        }

        public void ViewOptions()
        {
            Console.Clear();
            Console.WriteLine("OPTIONS");

            Console.WriteLine("Input max value and count attemps:");
            Console.WriteLine("(for example 100,10)");
        }
    }
}
