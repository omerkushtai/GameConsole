using System;
using System.Runtime.CompilerServices;

namespace GameConsole.Base;

internal class Menuscreen : Screen
{
    private List<Menuitem> menuitems
    {
        get; set;
    }
    public Menuscreen(string title) : base(title)
    {
        menuitems = new List<Menuitem>();
    }
    public void add(Menuitem item)
    {
        if(item != null ){
        menuitems.Add(item);
        }
    }
    public void add(String displayname, Screen screen)
    {
        if(displayname != null && screen != null){
        Menuitem item = new Menuitem(displayname, screen);
        menuitems.Add(item);
        }
    }
    public override void Show()
    {
        base.Show();
        centerText("choose ur screen");
        bool exit=false;
        int choice=0;
        while(!exit){
            for (int i = 0; i < menuitems.Count; i++)
            {
                centerText($"{i + 1}-{menuitems[i].displayname}");
            }
            centerText($"({menuitems.Count+1 }-exit)");
        
            centerText($"choose between 1-{menuitems.Count}");
            int.TryParse(Console.ReadLine(), out choice);
            if (choice > 0 && choice <= menuitems.Count)
            {
                exit=true;

            }
        }
        Console.Clear();
        if(choice <= menuitems.Count)
        {
            menuitems[choice-1].screen.Show();
        }
        Console.ReadKey();
    }
}

