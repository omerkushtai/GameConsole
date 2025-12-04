using System;

namespace GameConsole.Models;

public class Highscore
{
    private String gamename;
    private int score;
    private DateTime date;
    public Highscore(String gamename, int score, DateTime date)
    {
        this.gamename = gamename;
        this.score = score;
        this.date = DateTime.Now;
    }

}
