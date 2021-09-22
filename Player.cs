using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        public string chosenGesture;
        public int score;
        public string name;
        public string[] gestureList;

        public Player(string chosenGesture, int score, string name, string gestureList)
        {
            this.chosenGesture = "";
            this.score = 0;
            this.name = "";
            this.gestureList = ["Rock", "Paper", "Scissors", "Lizard", "Spock"];
            Console.WriteLine(gestureList);
        }
    }
}
