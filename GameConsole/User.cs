using System;

namespace GameConsole;

public class User
{
    public String username
    {
        get; set;
    }
    public int password
    {
        get; set;
    }
    public string name{
        get; set;
    }
    public User (String username,int password,string name)
    {
        this.username=username;
        this.password=password;
        this.name=name;
    }

}
