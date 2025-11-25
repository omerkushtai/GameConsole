using System;
using GameConsole.Base;

namespace GameConsole.pages;

public class Login : Base.Screen
{
    public Login() : base("Login Screen")
    {
    }
    public override void Show()
    {
        base.Show();
        centerText("enter your login details");
        

        Console.ReadKey();
    }
}
