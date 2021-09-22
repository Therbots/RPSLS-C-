using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public Human(int chosenGesture, int score, string name, string gestureList) : base(chosenGesture, score, name, gestureList)
        {
            Console.WriteLine("Enter Your Name: ");
            this.name = Console.ReadLine();
            Console.WriteLine($"{name} Choose Your Gesture! 1 for Rock, 2 for Paper, 3 for Scissors, 4 for Lizard, or 5 for Spock: ");
            this.chosenGesture = int.Parse(Console.ReadLine());
        }
    }
}
