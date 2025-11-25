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
        centerText(title);
    }
    public void centerText(string text)
    {
    Console.SetCursorPosition((Console.WindowTop + Console.WindowWidth / 2)-text.Length/2, Console.CursorTop);
    Console.WriteLine(text);
    }
    public Screen (string title)
    {
        this.title= title;
    }

}
