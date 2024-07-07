
using Variant2;

IViewGame viewGame = new ViewGameInConsole();
IInputControler inputControler = new KeyboardControler();
Game game = new Game(viewGame, inputControler);
game.Start();