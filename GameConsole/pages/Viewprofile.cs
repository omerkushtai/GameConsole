using System;

namespace GameConsole.pages;

public class Viewprofile: Base.Screen
{

    public Viewprofile() : base("view profile")
    {
    }

    public override void Show()
    {
        base.Show();
        centerText("Username: " + Consolegame.user.username);
        centerText("password: " + Consolegame.user.password);
        centerText("----------------");
        centerText("Press any key to return to Profile Menu");
        Console.ReadKey();
        Profilemenu profilemenu = new Profilemenu();
        profilemenu.Show();
    }
    private void centerText(string text)
    {
        int screenWidth = Console.WindowWidth;
        int textLength = text.Length;
        int spaces = (screenWidth - textLength) / 2;
        Console.WriteLine(new string(' ', spaces) + text);
    }
}
