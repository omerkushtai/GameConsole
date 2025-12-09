using System;
using GameConsole.Models;
using System.Collections.Generic;

namespace GameConsole.Data;

public class Userlist
{
    private static List<User> users=new List<User>()
    {
        new User("omer","omer123","Omer"),
        new User("admin","admin123","Admin")
        
    };
    
    public static void register(User user)
    {
        if(user != null){
        users.Add(user);
        }
    }
    public static User login(String username,String password)
    {
        foreach(User user in users)
        {
            if(user.username==username && user.password==password)
            {
                return user;
            }
        }
        return null;
    }  
    public static void Update(User u)
    {
        Boolean found=false;
        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].username == u.username)
            {
                users[i] = u;
                found = true;
                break;
            }

        }
        if (!found)
        {
            throw InvalidOperationException ("User not found");
        }
    }

    private static Exception InvalidOperationException(string v)
    {
        throw new NotImplementedException();
    }
}
