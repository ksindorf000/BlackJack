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
        Two, Three, Four, Five,
        Six, Seven, Eight, Nine,
        Ten, Jack, Queen, King, Ace
    }

    public class Cards
    {
        public Suit suit;
        public Face face;
        private int value;

        /************************************
         * Default Constructor
         ***********************************/
        public Cards()
        {
        }

        /************************************
         * Overload Constructor
         ***********************************/
        public Cards(Suit _suit, Face _face, int _value)
        {
            face = _face;
            suit = _suit;
            value = _value;
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

        /************************************
         * DisplayValue()
         ***********************************/
        public int DisplayValue()
        {
            return value;
        }

    }
}
