using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public enum State
    {
        NoBust, Bust, Won
    }

    public class Player
    {
        public string name;
        public int score;
        public State currentState = State.NoBust; 

        /************************************
         * Default Constructor
         ***********************************/
        public Player()
        {
        }

        /************************************
        * Constructor
        ***********************************/
        public Player(string _name)
        {
            name = _name;
        }

        /************************************
         * CalcScore()
         ***********************************/
        public static int CalcScore(Player whoseTurn)
        {
            List<Cards> hand = new List<Cards>();

            if (whoseTurn.name.ToLower() == "player")
            {
                hand = Dealer.playerHand;
            }
            else
            {
                hand = Dealer.dealerHand;
            }

            foreach (var card in hand)
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
