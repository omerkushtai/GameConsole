using System;

namespace GameConsole.pages;

internal class Mainmenu : Base.Menuscreen
{
    public Mainmenu() : base("main menu")
    {
        add("register", new Register());
        add("login", new Login());
    }
}

