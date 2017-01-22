using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static bool gameOn = true;
        static List<Player> playerList = new List<Player>();

        static void Main(string[] args)
        {
            //Create Deck
            List<Cards> deck1 = Deck.CreateDeck();

            //Create Player and Dealer
            Dealer dealer = new Dealer();
            Player player = new Player("Player");

            //Add Player and Dealer to List<Players>
            playerList.Add(dealer);
            playerList.Add(player);

            //Initial Deal of two cards per player
            PlayGame.InitialDeal(playerList, deck1);

            //Play the game
            while (gameOn)
            {
                foreach (Player p in playerList)
                {
                    if (p.name == "Dealer")
                    {
                        continue;
                    }

                    Player.CalcScore(p);
                    Player.WinConditions(p);

                    if (p.currentState == State.Bust || p.currentState == State.Won)
                    {
                        gameOn = false;
                        PlayGame.DisplayFinal(playerList);
                    }
                    else if (p.currentState == State.NoBust)
                    {
                        PlayGame.HitOrStay(p, deck1);
                        Player.CalcScore(p);
                        Player.WinConditions(p);
                        gameOn = true;
                    }
                }
            }

            //PlayGame.DisplayFinal(playerList);

        }
    }
}
