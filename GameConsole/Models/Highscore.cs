using System;

namespace GameConsole.Models;


    public class HighScore
    {
        public int Score { get; set; }
        public string gameName { get; set; }
        public DateTime dates { get; set; }
        private string name;
        internal int score;

        public HighScore(int score, string gameName )
        {
         
            Score = score;
            this.gameName = gameName;
            this.dates = DateTime.Now;

        }

        public HighScore(string name, int score)
        {
            this.name = name;
            Score = score;
        }
    }



