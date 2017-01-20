using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        static private List<Cards> playerHand = new List<Cards>();
        static private int count = 0;

        private static List<Cards> AddToHand()
        {
            count ++;
            playerHand.Add(Deck.CreateDeck()[count]);

            return playerHand;
        }

        public static List<Cards> DisplayHand()
        {
            return playerHand;
        }
    }
}
