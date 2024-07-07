using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_DZ3
{
    internal class ViewGame
    {
        private readonly Game Game;

        public ViewGame(Game game)
        {
            Game = game;
        }

        public void StartGame()
        {
            ViewMainMenu();
        }

        private void ViewMainMenu()
        {
            int cmd;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hello! Try to play game");
                Console.WriteLine();
                Console.WriteLine("Main menu:");
                Console.WriteLine("1 - New game");
                Console.WriteLine("2 - Set options");
                Console.WriteLine("3 - Exit");
                Console.WriteLine("Input command:");
                cmd = GetInputInt(1, 3);

                if (cmd == 1)
                {
                    Game.NewGame();
                    View();
                }
                else if (cmd == 2)
                {
                    ViewOptionsMenu();
                }
                else if (cmd == 3)
                {
                    break;
                }
            }
        }

        private void View()
        {
            Console.Clear();
            Console.WriteLine($"Game started. Range 0..{Game.MaxValue}. Attemps {Game.CountAttempts}");

            while (true)
            {
                Console.WriteLine($"Count {Game.GetCount()}");
                ResultGame resultGame = Game.CheckNumber(GetInputInt(0, Game.MaxValue));

                if (resultGame == ResultGame.Winner)
                {
                    Console.WriteLine("You Winner!!!");
                    Console.ReadLine();
                    break;
                }
                else if (resultGame == ResultGame.GameOver)
                {
                    Console.WriteLine("Game over");
                    Console.ReadLine();
                    break;
                }
                else if (resultGame == ResultGame.Less)
                {
                    Console.WriteLine("Input less:");
                }
                else if (resultGame == ResultGame.Greater)
                {
                    Console.WriteLine("Input greater:");
                }
            }
        }

        private void ViewOptionsMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu options");

            Console.WriteLine("Input max value:");
            int maxValue = GetInputInt(0, 1000);

            Console.WriteLine("Input count attemps:");
            int countAttemps = GetInputInt(0, 100);

            Game.SetParams(maxValue, countAttemps);

            Console.Clear();
        }

        private int GetInputInt(int min, int max)
        {
            int result;
            while (true)
            {
                try
                {
                    result = Int32.Parse(Console.ReadLine());
                    if (result < min || result > max)
                        Console.WriteLine($"Please input in range {min}..{max}");
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine($"Please input in range {min}..{max}");
                }
            }
            return result;
        }
    }
}
