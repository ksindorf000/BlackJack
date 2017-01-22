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
            List<Cards> deck1 = Deck.CreateDeck();

            Dealer dealer = new Dealer();
            Player player = new Player("Player");

            playerList.Add(dealer);
            playerList.Add(player);

            PlayGame.InitialDeal(playerList, deck1);

            while (gameOn)
            {
                PlayGame.DisplayFinal(playerList);

                foreach (Player p in playerList)
                {
                    Player.CalcScore(p);

                    if (p.currentState == State.Bust || p.currentState == State.Won)
                    {
                        gameOn = false;
                        PlayGame.DisplayFinal(playerList);
                    }
                    else if (p.currentState == State.NoBust)
                    {
                        PlayGame.HitOrStay(p, deck1);
                        gameOn = true;
                    }
                }
            }

        }
    }
}
