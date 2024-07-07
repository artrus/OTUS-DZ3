using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant2
{
    internal class KeyboardControler : IInputControler
    {
        public GameCommand GetCommandInMainMenu()
        {
            while (true)
            {
                int command = int.Parse(Console.ReadLine());

                if ((command <= 0) || (command >= 4))
                {
                    continue;
                }
                else if (command == 1)
                {
                    return GameCommand.NewGame;
                }
                else if (command == 2)
                {
                    return GameCommand.Options;
                }
                else if (command == 3)
                {
                    return GameCommand.Exit;
                }
            }
        }

        public GameOptions GetOptions()
        {
            GameOptions gameOptions = new GameOptions();
            while (true)
            {
                try
                {
                    string[] str = Console.ReadLine().Split(',');
                    gameOptions.MaxValue = int.Parse(str[0]);
                    gameOptions.CountAttempts = int.Parse(str[1]);
                    break;
                }
                catch
                {
                    continue;
                }
            }
            return gameOptions;
        }

        public int GetValue(int min, int max)
        {
            int value;
            while (true)
            {
                try
                {
                    value = Int32.Parse(Console.ReadLine());
                    if (value < min || value > max)
                        Console.WriteLine($"Please input in range {min}..{max}");
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine($"Please input in range {min}..{max}");
                }
            }
            return value;
        }
    }
}
