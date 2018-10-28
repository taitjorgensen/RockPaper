using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    class Human : Player
    {


        
        public override string PlayGesture()
        {
            Console.WriteLine("Please enter your gesture.");
            gesturePlayed = Console.ReadLine();
            return gesturePlayed;
        }
    }
}
