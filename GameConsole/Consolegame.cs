using System;
using GameConsole.Base;
using GameConsole.pages;

namespace GameConsole;

internal class Consolegame
{
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
