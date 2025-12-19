using System;

namespace GameConsole.pages;

public class Profilemenu : Base.Menuscreen
{
    public Profilemenu() : base("profile menu")
    {
        add("view profile", new Viewprofile());
        add("edit profile", new Updateprofile());
        add("game history", new HistoryScreen()); 
    }
}
