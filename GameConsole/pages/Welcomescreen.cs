using System;
using GameConsole.Base;

namespace GameConsole.pages;

internal class Welcomescreen : Base.Screen
{
    public Welcomescreen() : base("welcome")
    {
    }
    public override void Show()
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
        base.Show();
        string text = "Welcome to Game Console!";
        centerText(text);
        centerText("press any key to continue...");

        Console.ReadKey();
        Screen next = new Mainmenu();
        next.Show();
    }

}
