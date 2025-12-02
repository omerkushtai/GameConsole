using System;
using GameConsole.Games;

namespace GameConsole.pages;

public class Gamemenu : Base.Menuscreen
{
    public Gamemenu() : base("game list")
    {
        add("Fluffy bird",new Gamescreen(new FluffyBirdGame()));
        add("pacman",new Gamescreen(new PacManGame()));
        add("Tetris",new Gamescreen(new TetrisGame()));
    }
}
