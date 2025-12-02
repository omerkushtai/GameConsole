using System;

namespace GameConsole.pages;

internal class Mainmenu : Base.Menuscreen
{
    public Mainmenu() : base("main menu")
    {
        add(new Base.Menuitem("register", new Register()));
        add("login", new Login());
    }
}

