using System;
using GameConsole.Models;

namespace GameConsole.pages;

public class Updateprofile : Base.Screen
{
    public Updateprofile() : base("update profile")
    {
    
    }
    public override void Show()
    {
        base.Show();
        User currentUser=Consolegame.user;
        centerText("press 1 to update username or 2 to update password");
        String choice=Console.ReadLine();
        if (choice == "1")
        {
            centerText("enter new username:");
            String newUsername=Console.ReadLine();
            if(newUsername!=null)
            {
                currentUser.username=newUsername;
                centerText("username updated successfully");
            }
            else
            {
                throw new ArgumentNullException("username cannot be empty");
            }
        }
        else if (choice == "2")
        {
            centerText("enter new password:");
            String newPassword=Console.ReadLine();
            if(newPassword!=null)
            {
                currentUser.password=newPassword;
                centerText("password updated successfully");
            }
            else
            {
                throw new ArgumentNullException("password cannot be empty");
            }
        }
        else
        {
            centerText("invalid choice");
           
        }
        
    }
}
