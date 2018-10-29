using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    class Game
    {
        //member variable

        Player playerOne;
        Player playerTwo;
        Result result = new Result();
        public int numberOfPlayers;
        private string playerOneGesture;
        private string playerTwoGesture;
        public List<string> gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
        private List<string> rules = new List<string> { "Scissors cuts Paper", "Paper covers Rock", "Rock crushes Lizard", "Lizard poisons Spock", "Spock smashes Scissors", "Scissors decapitates Lizard", "Lizard eats Paper", "Paper disproves Spock", "Spock vaporizes Rock" };
        public string playAgainResponse;
        
        //constructor


        //member methods
        public void RunGame()
        {
            DisplayRules(rules);
            int numberOfPlayers = DetermineNumberOfHumanPlayers();
            SetPlayers(numberOfPlayers);

            while(result.playerOneScore < 2 && result.playerTwoScore < 2)
            {
                PlayRound(playerOne, playerTwo);
            }
            DetermineGameWinner(result);


        }
        private void DisplayRules(List<string> rules)
        {
            foreach (string rule in rules)
            {
                Console.WriteLine(rule);
            }

        }
        public int DetermineNumberOfHumanPlayers()
        {
            Console.WriteLine("Please enter number of players. Valid if 0, 1, or 2 people are playing");
            numberOfPlayers = int.Parse(Console.ReadLine());
            if (numberOfPlayers > 2)
            {
                Console.WriteLine("Too many players. Please enter 0 - 2");
                Console.ReadLine();
                DetermineNumberOfHumanPlayers();
            }
            else if (numberOfPlayers < 0)
            {
                Console.WriteLine("Not enough players. Please enter 0 - 2");
                Console.ReadLine();
                DetermineNumberOfHumanPlayers();
            }
            return numberOfPlayers;
        }

        public void SetPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if (numberOfPlayers == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else if (numberOfPlayers == 0)
            {
                playerOne = new Computer();
                playerTwo = new Computer();
            }
        }
        public void PlayRound(Player playerOne, Player playerTwo)
        {
            playerOne.PlayGesture();
            playerTwo.PlayGesture();
            
            result.RoundResult(playerOne, playerTwo);
            playerOneGesture = result.playerOneGesture;
            playerTwoGesture = result.playerTwoGesture;

            Console.WriteLine("Player one has played: " + playerOneGesture);
            Console.WriteLine("Player two has played: " + playerTwoGesture);
            Console.ReadLine();
            Console.WriteLine("Player One score is: " + result.playerOneScore);
            Console.WriteLine("Player Two score is: " + result.playerTwoScore);

        }

        public void DetermineGameWinner(Result result)
        {

            if (result.playerOneScore == 2)
            {
                Console.WriteLine("Player One Wins!");
                Console.ReadLine();
                Console.WriteLine("Would you like to play again? y or n?");
                playAgainResponse = Console.ReadLine();
            }

            else if (result.playerTwoScore == 2)
            {
                Console.WriteLine("Player Two Wins!");
                Console.ReadLine();
                Console.WriteLine("Would you like to play again? y or n?");
                playAgainResponse = Console.ReadLine();
            }
            if (playAgainResponse == "y")
            {
                result.playerOneScore = 0;
                result.playerTwoScore = 0;
                RunGame();
            }

        }


    }
}
