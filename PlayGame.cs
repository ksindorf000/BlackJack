using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class PlayGame
    {
          /*******************************************************
         * DisplayBoard()
         *      Displays hands of each player/dealer
         *      Intend to add funcionality for multiple players
'         ******************************************************/
        public static void DisplayBoard(Player dealer, Player player)
        {
            Console.WriteLine("Player's Hand: ");

            foreach (Cards card in Dealer.playerHand)
            {
                Console.Write(card.DisplayFace() + " ");
                Console.Write(card.DisplaySuit() + "\n");
            }

            Console.WriteLine("\nDealer's Hand: ");

            foreach (Cards card in Dealer.dealerHand)
            {
                Console.Write(card.DisplayFace() + " ");
                Console.Write(card.DisplaySuit() + "\n");
            }
        }

          /*******************************************************
         * InitialDeal()
         *      Deals and displays two cards for player
         *      Deals two cards and displays one for dealer
'         ******************************************************/
        public static void InitialDeal(Player dealer, Player player, List<Cards> deck)
        {
            Dealer.DealCardToHand(player, deck);
            Dealer.DealCardToHand(player, deck);
            Dealer.DealCardToHand(dealer, deck);
            DisplayBoard(dealer, player);
        }

    }

}

