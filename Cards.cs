using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public enum Suit
    {
        Hearts,
        Spades,
        Clubs,
        Diamonds
    }

    public enum Face
    {
        Two = 2, Three = 3, Four = 4,
        Five = 5, Six = 6, Seven = 7, Eight = 8,
        Nine = 9, Ten = 10,  Jack = 10, Queen = 10,
        King = 10, Ace = 11
    }

    public class Cards
    {
        public Suit suit;
        public Face face;

        /************************************
         * Default Constructor
         ***********************************/
        public Cards()
        {
        }

        /************************************
         * Overload Constructor
         ***********************************/
        public Cards(Suit _suit, Face _face)
        {
            face = _face;
            suit = _suit;
        }

        /************************************
         * DisplaySuit()
         ***********************************/
        public Suit DisplaySuit()
        {
            return suit;
        }

        /************************************
         * DisplayFace()
         ***********************************/
        public Face DisplayFace()
        {
            return face;
        }

    }
}
