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
        Two = 2, Three = 3, Four,
        Five, Six, Seven, Eight,
        Nine, Jack = 10, Queen = 10,
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
         * Constructor
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
