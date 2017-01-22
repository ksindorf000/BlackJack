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
            Console.Write("Dealer's Hand: ");
        }

        /*****************************************
         * InitialDeal()
         *      Creates deck
         *      Deals two cards to each player
         *      Displays one card for dealer
         *      Displays two cards for player
         ****************************************/
        public static void InitialDeal(Player player, Player dealer)
        {
            deck1 = Dealer.GetDeck();

            Dealer.DealCardToHand(player);
            Dealer.DealCardToHand(player);

            Dealer.DealCardToHand(dealer);

            Console.WriteLine("\n");
            Dealer.DisplayHand(player);
            Console.Write("\t \t \t");
            Dealer.DisplayHand(dealer);

            Dealer.DealCardToHand(dealer);

            Console.ReadLine();
        }
    }
}

