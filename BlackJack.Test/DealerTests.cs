using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack.Test
{

    [TestClass]
    public class DealerTests
    {
        /****************************************
         * Does Dealer deal a random card and 
         * remove it from the deck?
         ****************************************/
        [TestMethod]
        public void DealCardFromDeck()
        {
            List<Cards> deck = Deck.CreateDeck();
            Player player = new Player("player");

            Dealer.DealCardToHand(player, deck);
            
            Assert.AreEqual(false, deck.Contains(player.hand[0]));
        }

        /****************************************
         * Are Dealer and Player hands different?
         ****************************************/
        [TestMethod]
        public void DifferentHands()
        {
            List<Cards> deck = Deck.CreateDeck();

            Player player = new Player("player");
            Player dealer = new Player("dealer");
            
            Dealer.DealCardToHand(player, deck);
            Dealer.DealCardToHand(dealer, deck);

            Assert.AreNotEqual(dealer.hand, player.hand);
        }
        
    }
}
