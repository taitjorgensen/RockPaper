using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    class Computer : Player
    {
        
        
        public override string PlayGesture()
        {
            Random computerGesture = new Random();
            int generated = computerGesture.Next(gestures.Count);
            if (generated == 0)
            {
                return gesturePlayed = "rock";
            }
            else if (generated == 1)
            {
                return gesturePlayed = "paper";
            }
            else if (generated == 2)
            {
                return gesturePlayed = "scissors";
            }
            else if (generated == 3)
            {
                return gesturePlayed = "lizard";
            }
            else if (generated == 4)
            {
                return gesturePlayed = "spock";
            }
            else
            {
                return "Invalid";
            }
            
            
        }

    }
}
