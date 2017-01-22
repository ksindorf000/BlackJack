using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer
    {
        static public List<Cards> dealerHand = new List<Cards>();
        static public List<Cards> playerHand = new List<Cards>();
        static public List<Cards> deck = new List<Cards>();

        /************************************
         * Default Constructor
         ***********************************/
        public Dealer()
        {
        }
        
        /************************************
         * GetDeck()
         ***********************************/
        public static List<Cards> GetDeck()
        {
            deck = Deck.CreateDeck();
            return deck;
        }

        /************************************
         * DealCardToHand()
         ***********************************/
        public static void DealCardToHand(Player whoseTurn)
        {
            if (whoseTurn.name.ToLower() == "player")
            {
                Random rng = new Random();
                Cards card = deck[rng.Next(deck.Count)];
                playerHand.Add(card);
                deck.Remove(card);
            }
            else
            {
                Random rng = new Random();
                Cards card = deck[rng.Next(deck.Count)];
                dealerHand.Add(card);
                deck.Remove(card);
            }
        }

        /************************************
         * DisplayHand()
         ***********************************/
        public static void DisplayHand(Player whoseTurn)
        {
            if (whoseTurn.name.ToLower() == "player")
            {
                foreach (Cards card in playerHand)
                {
                    Console.Write(card.DisplayFace() + " ");
                    Console.Write(card.DisplaySuit());
                }
            }
            else
            {
                foreach (Cards card in dealerHand)
                {
                    Console.Write(card.DisplayFace() + " ");
                    Console.Write(card.DisplaySuit());
                }
            }
        }
    }
}
