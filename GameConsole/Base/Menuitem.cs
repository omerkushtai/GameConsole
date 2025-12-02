using System;

namespace GameConsole.Base;

public class Menuitem
{
public String displayname
    {
        get; set;
    }
public Screen screen
    {
        get; set;
    }
public Menuitem (String displayname, Screen screen)
{
this.displayname=displayname;
this.screen=screen;
}
}
