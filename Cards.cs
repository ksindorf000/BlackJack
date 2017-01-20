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
        One, Two, Three, Four,
        Five, Six, Seven, Eight,
        Nine, Jack, Queen, King, Ace
    }

    public class Cards
    {
        public Suit suit;
        public Face face;


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
