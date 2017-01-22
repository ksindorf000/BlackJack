using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class PlayGame
    {
        public static List<Cards> deck1 = new List<Cards>();

        /************************************
         * DisplayTable()
         ***********************************/
        public static void DisplayTable()
        {
            Console.Write("Player's Hand: \t \t \t");
            Console.Write("Dealer's Hand: \n");
        }

        /*****************************************
         * InitialDeal()
         *      Deals 2 cards to player/dealer
'         ****************************************/
        public static void InitialDeal(Player dealer, Player player, List<Cards> deck)
        {
            Dealer.DealCardToHand(player, deck);
            Dealer.DealCardToHand(player, deck);
            DisplayHand(player);

            Dealer.DealCardToHand(dealer, deck);
            DisplayHand(dealer);
            Dealer.DealCardToHand(dealer, deck);

            Console.ReadLine();
        }

        /*****************************************
         * DisplayHand()
         *      Displays hand of selected player/dealer
'         ****************************************/
        public static void DisplayHand(Player whoseHand)
        {
            if (whoseHand.name.ToLower() == "player")
            {
                foreach (Cards card in Dealer.playerHand)
                {
                    Console.Write(card.DisplayFace() + " ");
                    Console.Write(card.DisplaySuit());
                }
            }
            else
            {
                foreach (Cards card in Dealer.dealerHand)
                {
                    Console.Write(card.DisplayFace() + " ");
                    Console.Write(card.DisplaySuit());
                }
            }
        }
    }
}

