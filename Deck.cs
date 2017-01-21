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
            var deck = new List<Cards>();

            CreateHearts(deck);
            CreateDiamonds(deck);
            CreateClubs(deck);
            CreateSpades(deck);

            return deck;
        }


        /*******************************************************************
         * CreateHearts()
         *      Creates cards with random Face value and set Suit of Hearts
         *      Adds cards to deck<Cards>
         ******************************************************************/
        public static void CreateHearts(List<Cards> deck)
        {
            for (int i = 0; i < 9; i++)
            {
                int count = i + 2;
                deck.Add(new Cards(Suit.Hearts, faceList[i], count));
            }

            deck.Add(new Cards(Suit.Hearts, Face.Jack, 10));
            deck.Add(new Cards(Suit.Hearts, Face.King, 10));
            deck.Add(new Cards(Suit.Hearts, Face.Queen, 10));
            deck.Add(new Cards(Suit.Hearts, Face.Ace, 11));
        }

        /**********************************************************************
         * CreateDiamonds()
         *      Creates cards with random Face value and set Suit of Diamonds
         *      Adds cards to deck<Cards>
         **********************************************************************/
        public static void CreateDiamonds(List<Cards> deck)
        {
            for (int i = 0; i < 9; i++)
            {
                int count = i + 2;
                deck.Add(new Cards(Suit.Diamonds, faceList[i], count));
            }

            deck.Add(new Cards(Suit.Diamonds, Face.Jack, 10));
            deck.Add(new Cards(Suit.Diamonds, Face.King, 10));
            deck.Add(new Cards(Suit.Diamonds, Face.Queen, 10));
            deck.Add(new Cards(Suit.Diamonds, Face.Ace, 11));
        }

        /*******************************************************************
         * CreateClubs()
         *      Creates cards with random Face value and set Suit of Clubs
         *      Adds cards to deck<Cards>
         ******************************************************************/
        public static void CreateClubs(List<Cards> deck)
        {
            for (int i = 0; i < 9; i++)
            {
                int count = i + 2;
                deck.Add(new Cards(Suit.Clubs, faceList[i], count));
            }

            deck.Add(new Cards(Suit.Clubs, Face.Jack, 10));
            deck.Add(new Cards(Suit.Clubs, Face.King, 10));
            deck.Add(new Cards(Suit.Clubs, Face.Queen, 10));
            deck.Add(new Cards(Suit.Clubs, Face.Ace, 11));
        }

        /*******************************************************************
         * CreateSpades()
         *      Creates cards with random Face value and set Suit of Spades
         *      Adds cards to deck<Cards>
         ******************************************************************/
        public static void CreateSpades(List<Cards> deck)
        {
            for (int i = 0; i < 9; i++)
            {
                int count = i + 2;
                deck.Add(new Cards(Suit.Spades, faceList[i], count));
            }

            deck.Add(new Cards(Suit.Spades, Face.Jack, 10));
            deck.Add(new Cards(Suit.Spades, Face.King, 10));
            deck.Add(new Cards(Suit.Spades, Face.Queen, 10));
            deck.Add(new Cards(Suit.Spades, Face.Ace, 11));
        }

    }
}
