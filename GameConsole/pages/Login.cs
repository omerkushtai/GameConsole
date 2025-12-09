using System;
using System.Runtime.InteropServices.Marshalling;
using GameConsole.Base;
using GameConsole.Models;

namespace GameConsole.pages;

public class Login : Base.Screen
{
    public Login() : base("Login Screen")
    {
    }
    public override void Show()
    {
        base.Show();
        centerText("press any key to continue to Login Menu");
        Console.ReadKey();
        centerText("enter usernme and password");
        String username=Console.ReadLine();
        String password=Console.ReadLine();
       if( username==null || password==null)
       {
       throw new ArgumentNullException("Fields cannot be empty");   
       }
        else
        {

            User u=Data.Userlist.login(username, password); 
            if(u!=null)
            {
                centerText("Login Successful");
                Consolegame.user=u;
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

