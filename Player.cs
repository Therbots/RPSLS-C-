using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        public int chosenGesture;
        public int score;
        public string name;
        public string[] gestureList;

        public Player(int chosenGesture, int score, string name, string gestureList)
        {
            this.chosenGesture = 0;
            this.score = 0;
            this.name = "";
            this.gestureList = new string[5] { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }

        public void setScore()
        {
            score += 1;
        }

    }
}
