using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public enum State
    {
        NoBust, Bust, Won, Stay
    }

    public class Player
    {
        public string name;
        public int score;
        public List<Cards> hand;
        public State currentState = State.NoBust;

        /************************************
         * Default Constructor
         ***********************************/
        public Player()
        {
            hand = new List<Cards>();
        }

        /************************************
        * Constructor
        ***********************************/
        public Player(string _name)
        {
            name = _name;
            hand = new List<Cards>();
        }

        /************************************
        * Override ToString()
        ***********************************/
        public override string ToString()
        {
            return $"{name}: {score} {currentState.ToString().ToUpper()}";
        }

        /************************************
         * CalcScore()
         ***********************************/
        public static int CalcScore(Player whoseTurn)
        {            
            foreach (var card in whoseTurn.hand)
            {
                whoseTurn.score += card.DisplayValue();
            }

            return whoseTurn.score;
        }


        /***********************************************************
         * WinConditions()
         *      Determines if the player/dealer has busted or won
         ***********************************************************/
        public static State WinConditions(Player whoseTurn)
        {
            if (whoseTurn.score > 21)
            {
                whoseTurn.currentState = State.Bust;
            }
            else if (whoseTurn.score == 21)
            {
                whoseTurn.currentState = State.Won;
            }
            else
            {
                whoseTurn.currentState = State.NoBust;
            }

            return whoseTurn.currentState;
        }


    }
}
