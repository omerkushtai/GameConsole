using System;
using GameConsole.Base;
using GameConsole.pages;
using GameConsole.Models;

namespace GameConsole;

internal class Consolegame
{
    public static User user;
    private Screen mainpage;
    public Consolegame()
    {
        mainpage=new Welcomescreen();
    }
    public void startapp()
    {
        mainpage.Show();
    }

}
