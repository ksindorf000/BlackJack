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

        /************************************
         * Default Constructor
         ***********************************/
        public Player()
        {
        }

        public virtual List<Cards> DisplayHand()
        {
            return playerHand;
        }


    }
}
