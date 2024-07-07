using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Variant2
{
    internal class Game
    {
        private IViewGame viewGame;
        private IInputControler inputControler;
        private GameOptions gameOptions;

        public Game(IViewGame viewGame, IInputControler inputControler)
        {
            this.viewGame = viewGame;
            this.inputControler = inputControler;
            gameOptions = new GameOptions();
        }

        public void Start()
        {
            viewGame.SayHello();
            MainMenu();
        }

        private void MainMenu()
        {
            while (true)
            {
                viewGame.ViewMenu();

                GameCommand gameCommand = inputControler.GetCommandInMainMenu();

                if (gameCommand == GameCommand.NewGame)
                {
                    NewGame();
                }
                else if (gameCommand == GameCommand.Options)
                    GetOptions();
                else if (gameCommand == GameCommand.Exit)
                    break;
            }
        }

        private void NewGame()
        {
            int hiddenNumber = new Random().Next(0, gameOptions.MaxValue);
            int count = gameOptions.CountAttempts - 1;

            viewGame.SayNewGame(gameOptions.MaxValue, gameOptions.CountAttempts);

            while (true)
            {
                int inputValue = inputControler.GetValue(0, gameOptions.MaxValue);

                if (inputValue == hiddenNumber)
                {
                    viewGame.SayYouWinner();
                    break;
                }
                else if (count == 0)
                {
                    viewGame.SayGameOver();
                    break;
                }

                count--;

                if (inputValue > hiddenNumber)
                {
                    viewGame.SayLess();
                }
                else
                {
                    viewGame.SayGreater();
                }
            }
        }

        private void GetOptions()
        {
            viewGame.ViewOptions();
            gameOptions = inputControler.GetOptions();
        }
    }
}
