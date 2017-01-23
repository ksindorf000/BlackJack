using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer : Player
    {
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
            Random rng = new Random();

            Cards card = deck[rng.Next(deck.Count())];

            whoseTurn.hand.Add(card);
            deck.Remove(card);
        }

        /************************************
         * ShowDealerHand()
         ***********************************/
        public static void ShowDealerHand(Player dealer)
        {
            foreach (Cards card in dealer.hand)
            {
                Console.Write(card.DisplayFace() + " ");
                Console.Write(card.DisplaySuit() + "\n");
            }
        }

        /*******************************************************
       * DealerTurn()
       *      Sets Dealers Move
        ******************************************************/
        public static void DealerTurn(Player dealer, List<Cards> deck)
        {
            string hitStay;

            while (dealer.currentState == State.NoBust)
            {
                CalcScore(dealer);
                WinConditions(dealer);

                if (dealer.currentState == State.NoBust && dealer.score <= 17)
                {
                    hitStay = "h";
                }
                else if (dealer.currentState == State.Bust)
                {
                    break;
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
