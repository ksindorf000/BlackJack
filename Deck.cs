using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
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
            CreateHearts(deck, rng);
            CreateHearts(deck, rng);
            CreateHearts(deck, rng);

            return deck;
        }


        /*******************************************************************
         * CreateHearts()
         *      Creates cards with random Face value and set Suit of Hearts
         *      Adds cards to deck<Cards>
         ******************************************************************/
        private static void CreateHearts(List<Cards> deck, Random rng)
        {
            for (int i = 0; i < 14; i++)
            {
                Array face = Enum.GetValues(typeof(Face));
                Random random = new Random();
                Face cardFace = (Face)face.GetValue(random.Next(face.Length));

                deck.Add(new Cards(Suit.Hearts, cardFace));
            }
        }

        /**********************************************************************
         * CreateDiamonds()
         *      Creates cards with random Face value and set Suit of Diamonds
         *      Adds cards to deck<Cards>
         **********************************************************************/
        private static void CreateDiamonds(List<Cards> deck, Random rng)
        {
            for (int i = 0; i < 14; i++)
            {
                Array face = Enum.GetValues(typeof(Face));
                Random random = new Random();
                Face cardFace = (Face)face.GetValue(random.Next(face.Length));

                deck.Add(new Cards(Suit.Diamonds, cardFace));
            }
        }

        /*******************************************************************
         * CreateClubs()
         *      Creates cards with random Face value and set Suit of Clubs
         *      Adds cards to deck<Cards>
         ******************************************************************/
        private static void CreateClubs(List<Cards> deck, Random rng)
        {
            for (int i = 0; i < 14; i++)
            {
                Array face = Enum.GetValues(typeof(Face));
                Random random = new Random();
                Face cardFace = (Face)face.GetValue(random.Next(face.Length));

                deck.Add(new Cards(Suit.Clubs, cardFace));
            }
        }

        /*******************************************************************
         * CreateSpades()
         *      Creates cards with random Face value and set Suit of Spades
         *      Adds cards to deck<Cards>
         ******************************************************************/
        private static void CreateSpades(List<Cards> deck, Random rng)
        {
            for (int i = 0; i < 14; i++)
            {
                Array face = Enum.GetValues(typeof(Face));
                Random random = new Random();
                Face cardFace = (Face)face.GetValue(random.Next(face.Length));

                deck.Add(new Cards(Suit.Spades, cardFace));
            }
        }

    }
}
