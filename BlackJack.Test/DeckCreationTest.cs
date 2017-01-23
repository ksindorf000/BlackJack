using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack.Test
{
    [TestClass]
    public class DeckCreationTest
    {
        /************************************
         * Does the Cards constructor work?
         ***********************************/
        [TestMethod]
        public void CardsCanBeCreated()
        {
            var sut = new Cards(Suit.Clubs, Face.Eight, 8);
            Assert.AreEqual(Suit.Clubs, sut.DisplaySuit());
            Assert.AreEqual(Face.Eight, sut.DisplayFace());
            Assert.AreEqual(8, sut.DisplayValue());
        }

        /****************************************
         * Does Deck create a deck of 52 cards?
         ****************************************/
        [TestMethod]
        public void FullDeckCreated()
        {
            var sut = Deck.CreateDeck();
            Assert.AreEqual(52, sut.Count);
        }

        /****************************************
         * Does Deck create 13 of each suit?
         ****************************************/
        [TestMethod]
        public void CorrectNumEachSuit()
        {
            var deck = new List<Cards>();
            var rng = new Random();

            Deck.CreateHearts(deck);

            Assert.AreEqual(13, deck.Count);
        }

    }
}
