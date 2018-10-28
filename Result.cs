using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    class Result
    {   
        //member variables
        //Result result = new Result();
        public string rock = "rock";
        public string paper = "paper";
        public string scissors = "scissors";
        public string lizard = "lizard";
        public string spock = "spock";
        public int playerOneScore = 0;
        public int playerTwoScore = 0;
        public string playerOneGesture;
        public string playerTwoGesture;

        //constructor


        //member methods
        public void RoundResult(Player playerOne, Player playerTwo)
        {
            playerOneGesture = playerOne.gesturePlayed;
            playerTwoGesture = playerTwo.gesturePlayed;
            if (playerOneGesture == rock && (playerTwoGesture == scissors || playerTwoGesture == lizard))
            {
                playerOneScore++;
            }
            else if (playerOneGesture == paper && (playerTwoGesture == rock || playerTwoGesture == spock))
            {
                playerOneScore++;
            }
            else if (playerOneGesture == scissors && (playerTwoGesture == paper || playerTwoGesture == lizard))
            {
                playerOneScore++; 
            }
            else if (playerOneGesture == lizard && (playerTwoGesture == paper || playerTwoGesture == spock))
            {
                playerOneScore++;
            }
            else if (playerOneGesture == spock && (playerTwoGesture == scissors || playerTwoGesture == rock))
            {
                playerOneScore++;
            }
            else if (playerTwoGesture == rock && (playerOneGesture == scissors || playerOneGesture == lizard))
            {
                playerTwoScore++;
            }
            else if (playerTwoGesture == paper && (playerOneGesture == rock || playerOneGesture == spock))
            {
                playerTwoScore++;
            }
            else if (playerTwoGesture == scissors && (playerOneGesture == paper || playerOneGesture == lizard))
            {
                playerTwoScore++;
            }
            else if (playerTwoGesture == lizard && (playerOneGesture == paper || playerOneGesture == spock))
            {
                playerTwoScore++;
            }
            else if (playerTwoGesture == spock && (playerOneGesture == scissors || playerOneGesture == rock))
            {
                playerTwoScore++;
            }
            else
            {
                Console.WriteLine("This round resulted in a draw.");
                Console.ReadLine();
            }
            
        }
        
    }
}
