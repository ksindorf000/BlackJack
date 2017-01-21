using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer
    {
        static private List<Cards> dealerHand = new List<Cards>();
        static private List<Cards> deck = new List<Cards>();

        /************************************
         * Default Constructor
         ***********************************/
        public Dealer()
        {
        }

        /************************************
         * Override DisplayHand()
         ***********************************/
        public Cards DisplayHand()
        {
            return dealerHand[0];
        }

        /************************************
         * GetDeck()
         ***********************************/
        private void GetDeck()
        {
            deck = Deck.CreateDeck();
        }

        /************************************
         * DealCards()
         ***********************************/
        public void DealCards(string playerTurn)
        {
            Random rng = new Random();
            for (int i = 0; i < 2; i++)
            {
                int index = rng.Next(deck.Count());
                dealerHand.Add(deck[index]);
            }
        }



    }
}
