using System;

namespace GameConsole;

public class User
{
    public String username
    {
        get; set;
    }
    public String password
    {
        get; set;
    }
    public string name{
        get; set;
    }
    public List<Models.Highscore> highscores{
        get; set;
    }
    public User (String username,String password,string name,List<Models.Highscore> highscores=null)
    {
        this.username=username;
        this.password=password;
        this.name=name;

    }

}
