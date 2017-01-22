﻿using System;
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

        /*******************************************************
        * HitOrStay()
        *       Ask and accept player move
        *       Call for validation
        *       Hit = deal card to hand
        *       Stay = end turn
        ******************************************************/
        public static void HitOrStay(Player whoseTurn, List<Cards> deck)
        {
            bool valid = true;
            string hitStay;

            do
            {
                Console.WriteLine($"{whoseTurn.name} Hit or Stay? (H/S): ");
                hitStay = Console.ReadLine().ToLower();
                valid = ValidateInput(hitStay);
            } while (!valid);

            PlayGame.PerformHitStay(whoseTurn, deck, hitStay);

        }

        /*******************************************************
        * ValidateInput()
        ******************************************************/
        public static bool ValidateInput(string hitStay)
        {
            if (hitStay == "h" || hitStay == "s")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /************************************
         * CalcScore()
         ***********************************/
        public static int CalcScore(Player whoseTurn)
        {
            whoseTurn.score = 0;

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
        public static bool WinConditions(Player whoseTurn)
        {
            bool gameOn = true; 

            if (whoseTurn.score > 21)
            {
                whoseTurn.currentState = State.Bust;
                gameOn = false;
            }
            else if (whoseTurn.score == 21)
            {
                whoseTurn.currentState = State.Won;
                gameOn = false;
            }
            else
            {
                whoseTurn.currentState = State.NoBust;
                gameOn = true;
            }

            return gameOn;
        }


    }
}
