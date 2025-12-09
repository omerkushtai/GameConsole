using System;

using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
namespace GameConsole.pages;

public class Register : Screen
{
    private string name;
    
    private string username;
    
    private string password;
    
    public Register() : base("register screen")
    {
        base.Show();
        centerText("enter your registration details");
    }
    public override void Show()
    {
        base.Show();
        centerText("enter your registration details");
        centerText("enter name");
        name=Console.ReadLine();
        centerText("enter username:");
        username=Console.ReadLine();
        centerText("enter password:");
        password=Console.ReadLine();
        if(username==null ||password==null|| name==null)
        {
            throw new ArgumentNullException("Fields cannot be empty");
        }
        else
        {
            Userlist.register(new User (username,password,name));
            centerText("Registration Successful");
            Console.ReadKey();
            Screen nextscreen=new Welcomescreen();
            nextscreen.Show();
        }
    }
}
