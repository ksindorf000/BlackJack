using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static List<Player> playerList = new List<Player>();
        static bool keepPlaying = true;
        static string userInput;

        static void Main(string[] args)
        {
            //Create Player and Dealer
            Dealer dealer = new Dealer();
            Player player = new Player("Player");

            //Add Player and Dealer to List<Players>
            playerList.Add(dealer);
            playerList.Add(player);

            while (keepPlaying)
            {
                //Create New Deck
                List<Cards> deck1 = Deck.CreateDeck();

                //Initial Deal of two cards per player
                PlayGame.InitialDeal(playerList, deck1);

                //Players Hit or Stay
                PlayGame.PlayerTurns(playerList, deck1);

                //Dealer plays turn
                Dealer.DealerTurn(dealer, deck1);

                //Display Final
                PlayGame.DisplayFinal(playerList);

                //Does the player want to keep playing?
                keepPlaying = ContinuePlay();
            }
        }

        /*******************************************************
        * ContinuePlay()
        *      Asks player if they want to keep playing
        *      Calls for validation of input
        *      Clears players hands if keepPlaying
        ******************************************************/
        private static bool ContinuePlay()
        {
            bool valid = false;

            while (!valid)
            {
                Console.WriteLine("Would you like to play again? (Y/N): ");
                userInput = Console.ReadLine().ToLower();
                valid = ValidateInput();
            }

            if (userInput == "n")
            {
                keepPlaying = false;
            }
            else
            {
                keepPlaying = true;
                ClearPlayerHands();
            }

            return keepPlaying;
        }

        /*******************************************************
        * ClearPlayerHands()
        ******************************************************/
        private static void ClearPlayerHands()
        {
            foreach (Player p in playerList)
            {
                p.hand = new List<Cards>();
            }
        }

        /*******************************************************
        * ValidateInput()
        ******************************************************/
        private static bool ValidateInput()
        {
            bool valid = true;

            if (userInput != "n" && userInput != "y")
            {
                Console.WriteLine("Invalid input.");
                valid = false;
            }
            else
            {
                valid = true;
            }

            return valid;
        }
    }
}
