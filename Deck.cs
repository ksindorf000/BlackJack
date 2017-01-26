using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        public static Face[] faceList = (Face[])Enum.GetValues(typeof(Face));

        /************************************
         * CreateDeck()
         *      Calls card creation methods
         *      Returns deck<Cards>
         ***********************************/
        public static List<Cards> CreateDeck()
        {
            List<Cards> deck = new List<Cards>();

            CreateCards(Suit.Hearts, deck);
            CreateCards(Suit.Spades, deck);
            CreateCards(Suit.Clubs, deck);
            CreateCards(Suit.Diamonds, deck);

            return deck;
        }

        /*******************************************************************
         * CreateCards()
         *      Creates cards with random Face value and passed Suit
         *      Adds cards to deck<Cards>
         ******************************************************************/
        public static void CreateCards(Suit suit, List<Cards> deck)
        {
            for (int i = 0; i < 9; i++)
            {
                int count = i + 2;
                deck.Add(new Cards(suit, faceList[i], count));
            }

            deck.Add(new Cards(suit, Face.Jack, 10));
            deck.Add(new Cards(suit, Face.King, 10));
            deck.Add(new Cards(suit, Face.Queen, 10));
            deck.Add(new Cards(suit, Face.Ace, 11));
        }
    }
}
