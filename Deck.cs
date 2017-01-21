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
            CreateSpades(deck);
            CreateDiamonds(deck);
            CreateClubs(deck);

            return deck;
        }


        /*******************************************************************
         * CreateHearts()
         *      Creates cards with random Face value and set Suit of Hearts
         *      Adds cards to deck<Cards>
         ******************************************************************/
        public static void CreateHearts(List<Cards> deck)
        {
            for (int i = 0; i < 9; i ++)
            {
                deck.Add(new Cards(Suit.Hearts, faceList[i]));
            }

            deck.Add(new Cards(Suit.Hearts, Face.Queen));
            deck.Add(new Cards(Suit.Hearts, Face.King));
            deck.Add(new Cards(Suit.Hearts, Face.Ace));
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
                deck.Add(new Cards(Suit.Diamonds, faceList[i]));
            }

            deck.Add(new Cards(Suit.Diamonds, Face.Queen));
            deck.Add(new Cards(Suit.Diamonds, Face.King));
            deck.Add(new Cards(Suit.Diamonds, Face.Ace));
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
                deck.Add(new Cards(Suit.Clubs, faceList[i]));
            }

            deck.Add(new Cards(Suit.Clubs, Face.Queen));
            deck.Add(new Cards(Suit.Clubs, Face.King));
            deck.Add(new Cards(Suit.Clubs, Face.Ace));
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
                deck.Add(new Cards(Suit.Spades, faceList[i]));
            }

            deck.Add(new Cards(Suit.Spades, Face.Queen));
            deck.Add(new Cards(Suit.Spades, Face.King));
            deck.Add(new Cards(Suit.Spades, Face.Ace));

        }

    }
}
