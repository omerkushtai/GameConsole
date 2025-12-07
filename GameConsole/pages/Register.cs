using System;
using System.Net.NetworkInformation;

namespace GameConsole.pages;

public class Register : Base.Screen
{
    private string username
    {
        get; set;
    }
    private string password
    {
        get; set;
    }
    public Register() : base("register screen")
    {
        base.Show();
        centerText("enter your registration details");
    }
    public override void Show(object data)
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
            Data.Userlist.register(new Models.User (username,password,name));
            centerText("Registration Successful");
            Console.ReadKey();
            Screen nextscreen=new Welcomescreen();
            nextscreen.Show();
        }
    }
}
