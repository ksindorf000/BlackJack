using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJack.Test
{
    [TestClass]
    public class PlayerTests
    {
        /*********************************************************
         * Does Player.CalcScore() accurately calculate playerHand?
         *********************************************************/
        [TestMethod]
        public void CheckPlayerScore()
        {
            Player player1 = new Player("player");

            Cards card1 = new Cards(Suit.Clubs, Face.Eight, 8);
            Cards card2 = new Cards(Suit.Clubs, Face.Jack, 10);

            player1.hand.Add(card1);
            player1.hand.Add(card2);
            
            Assert.AreEqual(18, Player.CalcScore(player1));
        }

        /*********************************************************
         * Does Player.WinConditions() accurately assign State?
         *********************************************************/
        [TestMethod]
        public void CheckWinConditions()
        {
            Player player = new Player("player");
            Player player2 = new Player("player2");
            Player dealer = new Player("dealer");

            player.score = 20;
            player2.score = 21;
            dealer.score = 23;

            Player.WinConditions(player);
            Player.WinConditions(player2);
            Player.WinConditions(dealer);

            Assert.AreEqual(State.NoBust, player.currentState);
            Assert.AreEqual(State.Won, player2.currentState);
            Assert.AreEqual(State.Bust, dealer.currentState);
        }
    }
}
