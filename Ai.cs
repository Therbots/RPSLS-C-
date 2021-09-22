using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace RPSLS
{
    class Ai : Player
    {
        public Ai(int chosenGesture, int score, string name, string gestureList) : base(chosenGesture, score, name, gestureList)
        {
            this.name = "Player 2";
            Random rand = new Random();
            int num = rand.Next(0, 6);
            this.chosenGesture = num;
           

        }
    }
}
