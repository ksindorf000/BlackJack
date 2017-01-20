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



        public static List<Cards> DisplayHand()
        {
            return playerHand;
        }
    }
}
