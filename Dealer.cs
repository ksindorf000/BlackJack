using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer : Player
    {
        static public List<Cards> dealerHand = new List<Cards>();
        static public List<Cards> playerHand = new List<Cards>();
        static private Random rng = new Random();


        /************************************
         * Default Constructor
         ***********************************/
        public Dealer() : base ()
        {
            name = "Dealer";
        }

        /************************************
         * DealCardToHand()
         ***********************************/
        public static void DealCardToHand(Player whoseTurn, List<Cards> deck)
        {
            Cards card = deck[rng.Next(deck.Count)];

            if (whoseTurn.name.ToLower() == "player")
            {               
                playerHand.Add(card);
                deck.Remove(card);
            }
            else
            {
                dealerHand.Add(card);
                deck.Remove(card);
            }
        }
    }
}
