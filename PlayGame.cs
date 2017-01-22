﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class PlayGame
    {

        /*******************************************************
       * InitialDeal()
       *      Deals and displays two cards for player
       *      Deals two cards and displays one for dealer
        ******************************************************/
        public static void InitialDeal(List<Player> playerList, List<Cards> deck)
        {
            foreach (Player p in playerList)
            {
                Dealer.DealCardToHand(p, deck);
                Dealer.DealCardToHand(p, deck);
            }

            DisplayBoard(playerList);
        }

        /*******************************************************
       * DisplayBoard()
       *      Displays hands of each player/dealer
       *      Intend to add funcionality for multiple players
        ******************************************************/
        public static void DisplayBoard(List<Player> playerList)
        {
            foreach (Player p in playerList)
            {
                Console.WriteLine($"{p.name}'s Hand: ");

                foreach (Cards card in p.hand)
                {
                    Console.Write(card.DisplayFace() + " ");
                    Console.Write(card.DisplaySuit() + "\n");
                }

                Console.WriteLine("\n");
            }
        }

        /*******************************************************
        * CheckForWinBust()
        ******************************************************/
        public static void CheckForWinBust(Player whoseTurn, List<Cards> deck)
        {
            int score = Player.CalcScore(whoseTurn);
            Player.WinConditions(whoseTurn);
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
                Console.WriteLine("Hit or Stay (H/S): ");
                hitStay = Console.ReadLine().ToLower();
                valid = ValidateInput(hitStay);
            } while (!valid);


            if (hitStay == "h")
            {
                Dealer.DealCardToHand(whoseTurn, deck);
            }
            else if (hitStay == "s")
            {
                whoseTurn.currentState = State.Stay;
            }

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

        /*******************************************************
       * DisplayFinal()
       *      Displays all players/dealer score and state
        ******************************************************/
        public static void DisplayFinal(List<Player> playerList)
        {
            foreach (Player p in playerList)
            {
                Console.WriteLine($"{p}");
            }
        }

    }

}

