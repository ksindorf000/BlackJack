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

        static void Main(string[] args)
        {
            string userInput;
            bool valid = true;

            while (keepPlaying)
            {
                //Create Deck
                List<Cards> deck1 = Deck.CreateDeck();

                //Create Player and Dealer
                Dealer dealer = new Dealer();
                Player player = new Player("Player");

                //Add Player and Dealer to List<Players>
                playerList.Add(dealer);
                playerList.Add(player);

                //Initial Deal of two cards per player
                PlayGame.InitialDeal(playerList, deck1);

                //Players Hit or Stay
                PlayGame.PlayerTurns(playerList, deck1);

                //Dealer plays turn
                Dealer.DealerTurn(dealer, deck1);

                //Display Final
                PlayGame.DisplayFinal(playerList);
            }

            while (valid)
            {
                Console.WriteLine("Would you like to play again? (Y/N): ");
                userInput = Console.ReadLine().ToLower();
                valid = ValidateInput(userInput);
            }
        }

        private static bool ValidateInput(string userInput)
        {
            bool valid = true;

            if (userInput == "y")
            {
                keepPlaying = true;
            }
            else if (userInput == "n")
            {
                keepPlaying = false;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                valid = false;
            }

            return valid;
        }
    }
}
