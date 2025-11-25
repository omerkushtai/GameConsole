using System;

namespace GameConsole.pages;

public class Register : Base.Screen
{
    private string username
    {
        get; set;
    }
    private string password
    {
        get; set;
    }
    public Register() : base("register screen")
    {
        base.Show();
        centerText("enter your registration details");
    }
}
