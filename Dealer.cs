using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer : Player
    {
        static private Random rng = new Random();

        /************************************
         * Default Constructor
         ***********************************/
        public Dealer() : base()
        {
            name = "Dealer";
            hand = new List<Cards>();
        }

        /************************************
         * DealCardToHand()
         ***********************************/
        public static void DealCardToHand(Player whoseTurn, List<Cards> deck)
        {
            Cards card = deck[rng.Next(deck.Count)];

            whoseTurn.hand.Add(card);
            deck.Remove(card);
        }

        /*******************************************************
       * DealerTurn()
       *      Sets Dealers Move
        ******************************************************/
        public static void DealerTurn(Player dealer, List<Cards> deck)
        {
            string hitStay;

            while (dealer.currentState != State.Won && dealer.currentState != State.Bust)
            {
                if (dealer.currentState == State.NoBust && dealer.score <= 17)
                {
                    hitStay = "h";
                }
                else
                {
                    hitStay = "s";
                }

                PlayGame.PerformHitStay(dealer, deck, hitStay);
            }

            
        }
    }
}
