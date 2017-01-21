using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cards> deck = Deck.CreateDeck();
            foreach(var card in deck)
            {
                Console.Write(card.DisplayFace() + " ");
                Console.Write(card.DisplaySuit() + " ");
                Console.WriteLine(card.DisplayValue());
                Console.WriteLine("\n");
            }
        }
    }
}
