using System;
using GameConsole.Interfaces;

namespace GameConsole.pages;

public class Gamescreen : Base.Screen
{
    private IGamePlay game;
    public Gamescreen(IGamePlay game) : base(game.Name)
    {
        this.game = game;
    }
    public override void Show()
    {
     base.Show();
     centerText($"press anything to continue");
      Console.ReadKey();
      game.Play();
    }

   
}
