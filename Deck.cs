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
            var rng = new Random();

            CreateHearts(deck, rng);
            CreateSpades(deck, rng);
            CreateDiamonds(deck, rng);
            CreateClubs(deck, rng);

            return deck;
        }


        /*******************************************************************
         * CreateHearts()
         *      Creates cards with random Face value and set Suit of Hearts
         *      Adds cards to deck<Cards>
         ******************************************************************/
        public static void CreateHearts(List<Cards> deck, Random rng)
        {
            for (int i = 0; i < faceList.Count(); i ++)
            {
                deck.Add(new Cards(Suit.Hearts, faceList[i]));
            }
        }

        /**********************************************************************
         * CreateDiamonds()
         *      Creates cards with random Face value and set Suit of Diamonds
         *      Adds cards to deck<Cards>
         **********************************************************************/
        public static void CreateDiamonds(List<Cards> deck, Random rng)
        {
            for (int i = 0; i < faceList.Count(); i++)
            {
                deck.Add(new Cards(Suit.Diamonds, faceList[i]));
            }
        }

        /*******************************************************************
         * CreateClubs()
         *      Creates cards with random Face value and set Suit of Clubs
         *      Adds cards to deck<Cards>
         ******************************************************************/
        public static void CreateClubs(List<Cards> deck, Random rng)
        {
            for (int i = 0; i < faceList.Count(); i++)
            {
                deck.Add(new Cards(Suit.Clubs, faceList[i]));
            }
        }

        /*******************************************************************
         * CreateSpades()
         *      Creates cards with random Face value and set Suit of Spades
         *      Adds cards to deck<Cards>
         ******************************************************************/
        public static void CreateSpades(List<Cards> deck, Random rng)
        {
            for (int i = 0; i < faceList.Count(); i++)
            {
                deck.Add(new Cards(Suit.Spades, faceList[i]));
            }
        }

    }
}
