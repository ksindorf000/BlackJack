using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class PlayGame
    {

        /*******************************************************
       * InitialDeal()
       *      Deals and displays two cards for player
       *      Deals two cards and displays one for dealer
        ******************************************************/
        public static void InitialDeal(List<Player> playerList, List<Cards> deck)
        {
            Console.Clear();

            //Each player/dealer gets two cards
            foreach (Player p in playerList)
            {
                if (p.name == "Dealer")
                {
                    Dealer.DealCardToHand(p, deck);
                }
                else
                {
                    Dealer.DealCardToHand(p, deck);
                    Dealer.DealCardToHand(p, deck);
                }
            }

            //Display both cards for everyone but the dealer
            foreach (Player p in playerList)
            {
                Console.WriteLine($"{p.name}'s Hand: ");

                if (p.name == "Dealer")
                {
                    Dealer.ShowDealerHand(p);
                    Console.WriteLine("\n");
                    Dealer.DealCardToHand(p, deck);
                    continue;
                }

                foreach (Cards card in p.hand)
                {
                    Console.Write(card.DisplayFace() + " ");
                    Console.Write(card.DisplaySuit() + "\n");
                }

                if (p.name == "Dealer")
                {
                    continue;
                }

                Console.WriteLine("\n");
            }
        }

        /*******************************************************
      * PlayerTurns()
      *      Calulates score and checks win conditions
      *      If !Win and !Bust, asks for player move
       ******************************************************/
        public static void PlayerTurns(List<Player> playerList, List<Cards> deck1)
        {
            bool gameOn = true;

            while (gameOn)
            {
                foreach (Player p in playerList)
                {
                    //Skip Dealer
                    if (p.name == "Dealer")
                    {
                        continue;
                    }

                    Player.CalcScore(p);
                    Player.WinConditions(p);

                    if (p.currentState == State.Bust || p.currentState == State.Won)
                    {
                        gameOn = false;
                        continue;
                    }
                    else if (p.currentState == State.NoBust)
                    {
                        Player.HitOrStay(p, deck1);
                        Player.CalcScore(p);
                        gameOn = Player.WinConditions(p); //Will need to change this before playing with multiple players
                    }
                    
                    if (gameOn == false)
                    {
                        break;
                    }

                }
                if (gameOn == true)
                {
                    gameOn = CheckAllStay(playerList);
                }

                Console.Clear();
                DisplayBoard(playerList);
                
            }
        }

        /*******************************************************
       * DisplayBoard()
       *      Displays hands of each player/dealer
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
        * PerformHitStay()
        *       If Hit, deal card to hand
        *       If Stay, change State
        ******************************************************/
        public static void PerformHitStay(Player whoseTurn, List<Cards> deck, string hitStay)
        {
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
        * CheckAllStay()
        *      Stops turns if all players have stayed
        ******************************************************/
        public static bool CheckAllStay(List<Player> playerList)
        {
            int count = 0;
            bool gameOn = true;

            for (int i = 1; i < playerList.Count; i++)
            {
                if (playerList[i].currentState == State.Stay)
                {
                    count++;
                }
            }

            if (count == (playerList.Count - 1))
            {
                gameOn = false;
            }

            return gameOn;
        }

        /*******************************************************
        * DisplayFinal()
        *      Displays all players/dealer score and state
        ******************************************************/
        public static bool DisplayFinal(List<Player> playerList)
        {
            Console.Clear();

            DisplayBoard(playerList);

            foreach (Player p in playerList)
            {
                Console.WriteLine($"{p}");
            }

            bool gameOn = false;
            return gameOn;
        }

    }

}

