using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        /************************************
         * Default Constructor
         ***********************************/
        public Player()
        {
        }

        /************************************
         * CalcScore()
         ***********************************/
        public static int CalcScore()
        {
            int score = 0;

            foreach (var card in Dealer.playerHand)
            {
                score += card.DisplayValue();
            }

            return score;
        }


    }
}
