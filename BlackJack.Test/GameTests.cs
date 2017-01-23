using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BlackJack.Test
{
    [TestClass]
    public class GameTests
    {
        /***************************************************
        * Does score/State accurately calculate after a hit?
        ****************************************************/
        [TestMethod]
        public void ScoreCalculatesAfterHit()
        {
            Player player1 = new Player("Player");
            List<Cards> deck1 = Deck.CreateDeck();

            Cards card1 = new Cards(Suit.Clubs, Face.Queen, 10);
            Cards card2 = new Cards(Suit.Clubs, Face.Ace, 10);

            player1.hand.Add(card1);
            player1.hand.Add(card2);

            PlayGame.PerformHitStay(player1, deck1, "h");
            Player.CalcScore(player1);
            Player.WinConditions(player1);

            Assert.AreEqual(State.Bust, player1.currentState);
        }

        /******************************************************
        * Does dealer play when all Player.States are "Stay"?
        *******************************************************/
        [TestMethod]
        public void CheckAllPlayerStates()
        {
            List<Player> playerList = new List<Player>();
            Player dealer = new Player("dealer");
            Player player1 = new Player("Player1");
            Player player2 = new Player("Player2");

            playerList.Add(dealer);
            playerList.Add(player1);
            playerList.Add(player2);

            player1.currentState = State.Stay;
            player2.currentState = State.Stay;

            Assert.AreEqual(false, PlayGame.CheckAllStay(playerList));
        }

    }

}
