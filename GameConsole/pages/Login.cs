using System;
using System.Runtime.InteropServices.Marshalling;
using GameConsole.Base;

namespace GameConsole.pages;

public class Login : Base.Screen
{
    public Login() : base("Login Screen")
    {
    }
    public override void Show(object data)
    {
        base.Show();
        centerText("press any key to continue to Login Menu");
        Console.ReadKey();
        Screen next = new Gamemenu();
        next.Show();
        centerText("enter usernme and password");
        String username=Console.ReadLine();
        String password=Console.ReadLine();
       if( username==null && password==null)
       {
       throw new ArgumentNullException("Fields cannot be empty");   
       }
        else
        {
            if(Data.Userlist.login(username, password)!=null)
            {
                centerText("Login Successful");
                Console.ReadKey();
                Screen nextscreen=new Gamemenu();
                nextscreen.Show();
            }
            else
            {
                centerText("Login Failed");
                Console.ReadKey();
                Screen nextscreen=new Welcomescreen();
                nextscreen.Show();
            }
        }
    }
    
}

