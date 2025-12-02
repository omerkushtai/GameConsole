using System;

namespace GameConsole;

internal class Userlist
{
    public List<User> users;
    public Userlist()
    {
        users=new List<User>();
    }
    public void register(User user)
    {
        if(user != null){
        users.Add(user);
        }
    }
    public User login(String username,int password)
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

}
