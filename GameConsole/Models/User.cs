using System;

namespace GameConsole.Models;

public class User
{
    public string username
    {
        get; set;
    }
    public string password
    {
        get; set;
    }
    public string name{
        get; set;
    }
    public List <HighScore> Highscores{
        get; set;
    }
    public User (string username,string password,string name,List<HighScore> highscores=null)
    {
        this.username=username;
        this.password=password;
        this.name=name;

    }

}
