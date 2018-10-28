using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    abstract class Player
    {
        //member variables
        protected List<string> gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
        public string gesturePlayed;

        
        //member methods
        abstract public string PlayGesture();
        
    }
}
