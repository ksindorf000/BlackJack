using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        public string name;
        public int score;

        /************************************
         * Default Constructor
         ***********************************/
        public Player(string _name)
        {
            name = _name;
        }

        /************************************
         * CalcScore()
         ***********************************/
        public static int CalcScore(Player whoseTurn)
        {
            List<Cards> hand = new List<Cards>();

            if (whoseTurn.name.ToLower() == "player")
            {
                hand = Dealer.playerHand;
            }
            else
            {
                hand = Dealer.dealerHand;
            }

            foreach (var card in hand)
            {
                whoseTurn.score += card.DisplayValue();
            }

            return whoseTurn.score;
        }


        /****************************************
         * HitOrStay()
         *      Determines dealer's next move
         ***************************************/
        public static void HitOrStay(Player whoseTurn)
        {
            while (whoseTurn.score < 17)
            {
                Dealer.DealCardToHand(whoseTurn);
            }
        }


    }
}
