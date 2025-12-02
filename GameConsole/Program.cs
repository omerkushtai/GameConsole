using GameConsole.Base;
using GameConsole.Interfaces;

namespace GameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<IGamePlay> games = new List<IGamePlay>();
            games.Add(new Games.TetrisGame());
            games.Add(new Games.FluffyBirdGame());
            games.Add(new Games.PacManGame());

            foreach (var game in games)
            {
                game.Play();
				Console.Write($" Game:{game.Name}");
				Console.WriteLine($"Score:{game.Score}");

            }
            Base.Screen mainScreen = new Base.Screen("home page");
            mainScreen.Show();
            */
            //
            //Screen s= new Base.Screen("home page");
            //s.Show();
            //Screen welcome = new pages.Welcomescreen();
            //welcome.Show();
            Consolegame game = new Consolegame();
            game.startapp();
		}
      
    }
}
