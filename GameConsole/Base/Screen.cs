using System;

namespace GameConsole.Base;

public class Screen
{
    public string title
    {
        get; set;
    }
    public virtual void Show()
    {
        Console.Clear();
        int spacing = (Console.WindowWidth-title.Length)/2;
        Console.Write(new String(' ',spacing));
        Console.WriteLine($"\t\t\t{title}");

    }
    public Screen (string title)
    {
        title= title;
    }

}
