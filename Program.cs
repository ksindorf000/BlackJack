using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Player dealer = new Player("dealer");
            Player player = new Player("player");

            List<Cards> deck1 = Deck.CreateDeck();

            PlayGame.InitialDeal(dealer, player, deck1);


        }
    }
}
